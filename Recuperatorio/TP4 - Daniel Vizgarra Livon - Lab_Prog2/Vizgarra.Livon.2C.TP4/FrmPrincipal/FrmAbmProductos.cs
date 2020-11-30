using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using ClasePrincipal;
using Comun;
using PersistenciaDeDatos;
using Excepciones;

namespace FrmPrincipal
{
        
    public partial class FrmAbmProductos : Form
    {
        public delegate void DelegadoModerador(object objeto,EAccionesABM accion);
        public event DelegadoModerador ElEvento;

        private Negocio negocio;
        private EAccionesABM mode;

        #region Constructores
        public FrmAbmProductos(Negocio negocio, EAccionesABM mode)
        {
            this.negocio = negocio;
            this.mode = mode;
            this.ElEvento += Moderador.ModerarDB;
           
            InitializeComponent();
            if(mode == EAccionesABM.Crear)
            { 
                    lblTitulo.Text = "CREACION";
                    cmbArticulo.Hide();
                    txtCodigo.Enabled = false;
            }
            else if(mode == EAccionesABM.Modificar || mode == EAccionesABM.Borrar)
            {
                txtCodigo.Enabled = false;
                cmbArticulo.DisplayMember = "descripcion";
                cmbArticulo.ValueMember = "codigo";
                cmbArticulo.DataSource = negocio.Productos;
                if (mode == EAccionesABM.Modificar)
                {
                    lblTitulo.Text = "MODIFICACION";                  
                }
                else if (mode == EAccionesABM.Borrar)
                {
                    lblTitulo.Text = "BORRAR";
                }
            }
                
        }
        #endregion

        #region Propiedades
        public Negocio Negocio
        {
            get
            {
                return this.negocio;
            }
            set
            {
                this.negocio = value;
            }
        }
        public EAccionesABM Mode
        {
            get
            {
                return this.mode;
            }
            set
            {
                this.mode = value;
            }
        }
        #endregion

        /// <summary>
        /// Metodo moderado por EaccionesABM que podrá crear un objeto y agregarlo a la base de datos, modificarlo y actualizar o borrar y actualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int stk;
            double precio;
            DialogResult answer;

            if (int.TryParse(txtStock.Text, out stk) && double.TryParse(txtPrecio.Text, out precio))
            {
                Producto productoModerado = new Producto(txtDescripcion.Text, txtMarca.Text, precio, stk);

                try
                { 
                    switch (mode)
                    {
                        case EAccionesABM.Crear:
                            answer = MessageBox.Show("Esta seguro?", "VA A CREAR UN ARTICULO.", MessageBoxButtons.YesNo);
                            if (answer == DialogResult.Yes)
                            {
                                MessageBox.Show("Artículo creado exitosamente.");
                                negocio += productoModerado;//agregar a lista
                                this.ElEvento.Invoke(productoModerado, mode);
                                this.DialogResult = DialogResult.OK;
                            }
                            this.Dispose();
                            break;

                        case EAccionesABM.Modificar:
                            foreach (Producto item in negocio.Productos)
                            {
                                answer = MessageBox.Show("Esta seguro?", "VA A MODIFICAR UN ARTICULO PERMANENTEMENTE.", MessageBoxButtons.YesNo);
                                if (answer == DialogResult.Yes)
                                {
                                    MessageBox.Show("Artículo modificado exitosamente.");
                                    this.ElEvento.Invoke(productoModerado, mode);
                                    this.DialogResult = DialogResult.OK;
                                    break;
                                }
                            }
                            this.Dispose();
                            break;

                        case EAccionesABM.Borrar:
                            foreach (Producto item in negocio.Productos)
                            {
                                if ((int)cmbArticulo.SelectedValue == item.Codigo)
                                {
                                    answer = MessageBox.Show("Esta seguro?", "VA A ELIMINAR PERMANENTEMENTE ESTE ARTICULO.", MessageBoxButtons.YesNo);
                                    if (answer == DialogResult.Yes)
                                    {
                                        MessageBox.Show("Artículo eliminado exitosamente.");
                                        negocio -= item;
                                        this.DialogResult = DialogResult.OK;
                                        this.ElEvento.Invoke(productoModerado, mode);
                                        break;
                                    }
                                }
                            }
                            this.Dispose();
                            break;

                        default:
                            break;
                    }
                    ActualizarForm();
                }
                catch (StringInvalidoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        /// <summary>
        /// establece con que campos completar los textbox en base a la coincidencia del codigo en cmbSelectedValue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Producto item in negocio.Productos)
            {
                if (item.Codigo == (int)cmbArticulo.SelectedValue)
                {
                    txtCodigo.Text = item.Codigo.ToString();
                    txtPrecio.Text = item.Precio.ToString();
                    txtDescripcion.Text = item.Descripcion.ToString();
                    txtMarca.Text = item.Marca.ToString();
                    txtStock.Text = item.Stock.ToString();
                    break;
                }
            }
        }
        /// <summary>
        /// Metodo que permite actualziar las lisas en referencia a la base de datos y actualizar la información volcada en los textbox
        /// </summary>
        public void ActualizarForm()
        {
            negocio.ActualizarListaProductos();
            foreach (Producto item in negocio.Productos)
            {
                if (item.Codigo == (int)cmbArticulo.SelectedValue)
                {
                    txtCodigo.Text = item.Codigo.ToString();
                    txtPrecio.Text = item.Precio.ToString();
                    txtStock.Text = item.Stock.ToString();
                }
            }
        }
    }
}
