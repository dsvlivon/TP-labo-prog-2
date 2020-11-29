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
using PersistenciaDeDatos;
using ClasePrincipal;
using Comun;


namespace FrmPrincipal
{
    public partial class FrmMenuPrincipal : Form
    {
        //public delegate void ManejoInformacion(Negocio negocio);
        //public static ManejoInformacion EventoTransferir;

        Negocio negocio = new Negocio();//esto m da 3 listas, productos,clientes y ventas
        Cliente cliente;

        public Cliente Cliente 
        { 
            get 
            { 
                return this.cliente; 
            } 
            set 
            { 
                this.cliente = value; 
            } 
        }
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

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            timer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNumeroCliente.ValueMember = "id";
            cmbNumeroCliente.DisplayMember = "nombre";
            cmbNumeroCliente.DataSource = negocio.Clientes;
            cmbArticulo.DisplayMember = "descripcion";
            cmbArticulo.ValueMember = "codigo";
            cmbArticulo.DataSource = negocio.Productos;
            //EventoTransferir += TransferirDatos;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        #region ManejoDeCliente
        private void cmbNumeroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Cliente item in negocio.Clientes)
            {
                if (item.Id == (int)cmbNumeroCliente.SelectedValue)
                {
                    txtNombreApellido.Text = String.Format("{0}, {1}", item.Apellido, item.Nombre);
                    txtDireccion.Text = item.Direccion;
                    txtTelefono.Text = item.Telefono;
                    txtDni.Text = item.Dni;
                    cliente = new Cliente(item.Nombre,item.Apellido, item.Dni,item.Id, item.Direccion, item.Telefono);
                }
            }
        }
        #endregion


        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {          
            foreach (Producto item in negocio.Productos)
            {
                if (item.Codigo== (int)cmbArticulo.SelectedValue)
                {
                    //string x = cmbArticulo.SelectedValue.ToString(); ;
                    txtCodigo.Text = item.Codigo.ToString();
                    txtPrecio.Text = item.Precio.ToString();
                    txtStock.Text = item.Stock.ToString();
                    nudCantidad.Maximum = item.Stock;
                    break;
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(nudCantidad.Value.ToString(), out int cantidad))
            {
                foreach (Producto item in negocio.Productos)
                {
                    if (item.Codigo == (int)cmbArticulo.SelectedValue)
                    {
                        negocio.Vender(item, cantidad);
                        //Vender instancia una venta y lo agrega a la lista
                        break;
                    }
                }
                rtbOrdenDeCompra.Text = negocio.ListarVentas();
                lblTotalAcumulado.Text = String.Format("{0}$", negocio.Neto); ;
            }
        }
        private void btnGenerarFc_Click(object sender, EventArgs e)
        {
            FrmFactura frm = new FrmFactura(negocio, cliente);
            DialogResult resultado = frm.ShowDialog();                    
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            negocio.ActualizarListaVentas();
            rtbOrdenDeCompra.Text = negocio.ListarVentas();
            lblTotalAcumulado.Text = String.Format("{0}$", negocio.Total);
        }

           
        private void btnCrearArticulo_Click(object sender, EventArgs e)
        {//puedo llamar el frm igual q el FrmFactura cada evento tiene scope local
            FrmAbmProductos frm = new FrmAbmProductos(negocio,EAccionesABM.Crear);
            DialogResult resultado = frm.ShowDialog();
            
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            FrmAbmProductos frm = new FrmAbmProductos(negocio, EAccionesABM.Modificar);
            DialogResult resultado = frm.ShowDialog();
        }

        private void btnBorrarArticulo_Click(object sender, EventArgs e)
        {
            FrmAbmProductos frm = new FrmAbmProductos(negocio, EAccionesABM.Borrar);
            DialogResult resultado = frm.ShowDialog();
        }
        

    }
}
