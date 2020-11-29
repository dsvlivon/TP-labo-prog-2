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

namespace FrmPrincipal
{
        
    public partial class FrmAbmProductos : Form
    {
        public delegate void DelegadoModerador(object objeto);
        public event DelegadoModerador ElEvento;

        //public delegate void ManejoInformacion(Negocio negocio);
        //public static ManejoInformacion EventoTransferir;

        private Negocio negocio;
        private EAccionesABM mode;

        #region Constructores
        public FrmAbmProductos(Negocio negocio, EAccionesABM mode)
        {
            this.negocio = negocio;
            this.mode = mode;
            this.ElEvento += Moderador.GuardarDatosDB;
           
            InitializeComponent();
            if(mode == EAccionesABM.Crear)
            { 
                    lblTitulo.Text = "CREACION";
                    cmbArticulo.Hide();
            }
            else if(mode == EAccionesABM.Modificar || mode == EAccionesABM.Borrar)
            {
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


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int stk;
            double precio;
            switch (mode)
            {
                case EAccionesABM.Crear:
                    #region Crear
                    /*if (int.TryParse(txtCodigo.Text, out int cod) && ValidarDisponibilidadDeCodigo(Negocio, cod))
                    {*/
                    if (int.TryParse(txtStock.Text, out stk) && double.TryParse(txtPrecio.Text, out precio))
                        {//cod,des,mar,precio,stk;
                            Producto productoNuevo = new Producto(txtDescripcion.Text, txtMarca.Text, precio, stk);
                            DialogResult answer = MessageBox.Show("Esta seguro?", "VA A CREAR UN ARTICULO.", MessageBoxButtons.YesNo);
                            if (answer == DialogResult.Yes)                
                            {
                                MessageBox.Show("Artículo creado exitosamente.");
                                negocio += productoNuevo;
                                this.ElEvento.Invoke(productoNuevo);
                                
                            }
                        //}
                    }
                    this.Dispose();
                    break;                    
                    #endregion

                case EAccionesABM.Modificar:
                    #region Modificar
                    foreach (Producto item in negocio.Productos)
                    {
                        if ((int)cmbArticulo.SelectedValue == item.Codigo)//cod,des,mar,precio,stk;
                        {
                            if (int.TryParse(txtStock.Text, out stk) && double.TryParse(txtPrecio.Text, out precio))
                            {
                                DialogResult answer = MessageBox.Show("Esta seguro?", "VA A MODIFICAR UN ARTICULO PERMANENTEMENTE.", MessageBoxButtons.YesNo);
                                if (answer == DialogResult.Yes)
                                {
                                    item.Descripcion = txtDescripcion.Text;
                                    item.Marca = txtMarca.Text;
                                    item.Stock = stk;
                                    item.Precio = precio;
                                    MessageBox.Show("Artículo modificado exitosamente.");
                                    break;
                                }
                            }
                        }
                    }
                    this.Dispose();
                    break;
                    #endregion

                case EAccionesABM.Borrar:
                    #region Borrar
                    foreach (Producto item in negocio.Productos)
                    {
                        if ((int)cmbArticulo.SelectedValue == item.Codigo)
                        {
                            DialogResult answer = MessageBox.Show("Esta seguro?", "VA A ELIMINAR PERMANENTEMENTE ESTE ARTICULO.", MessageBoxButtons.YesNo);
                            if (answer == DialogResult.Yes)
                            {
                                MessageBox.Show("Artículo eliminado exitosamente.");
                                negocio -= item;
                                break;
                            }
                        }
                    }
                    this.Dispose();
                    break;
                    #endregion
                default:
                break;
            }
        }

           
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
        public static bool ValidarDisponibilidadDeCodigo(Negocio negocio, int codigo)
        {
            foreach (Producto item in negocio.Productos)
            {
                if (codigo == item.Codigo)
                {
                    return false;
                }
            }           
            return true;
        }


        
    }
}
