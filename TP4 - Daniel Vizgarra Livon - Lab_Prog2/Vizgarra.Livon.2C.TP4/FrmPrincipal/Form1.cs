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


namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
        Negocio negocio = new Negocio();//esto m da 3 listas, productos,clientes y ventas
        

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNumeroCliente.DataSource = negocio.Clientes;
            cmbNumeroCliente.DisplayMember = "id";
            cmbNumeroCliente.ValueMember = "id";
            cmbArticulo.DataSource = negocio.Productos;
            cmbArticulo.DisplayMember = "descripcion";
            cmbArticulo.ValueMember = "codigo";
        }

        private void cmbArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {          
            foreach (Producto item in negocio.Productos)
            {
                if (item.Codigo == ((Producto)cmbArticulo.SelectedValue).Codigo)
                {
                    txtDescripcionArticulo.Text = item.Descripcion;
                    txtPrecio.Text = item.Precio.ToString();
                }
            }
        }

        private void cmbNumeroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Cliente item in negocio.Clientes)
            {
                if (item.Id == ((Cliente)cmbNumeroCliente.SelectedValue).Id)
                {
                    txtNombreApellido.Text = String.Format("{0}, {1}", item.Apellido, item.Nombre);
                    txtDireccion.Text = item.Direccion;
                    txtTelefono.Text = item.Telefono;
                    txtDni.Text = item.Dni;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad;
            if (int.TryParse(this.txtCantidad.Text, out cantidad))
            {

            }
        }

        
    }
}
