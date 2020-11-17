using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasePrincipal;
using Entidades;


namespace FrmPrincipal
{
    public partial class FrmFactura : Form
    {

        public FrmFactura(Negocio negocio, Cliente cliente)
        {
            InitializeComponent();
            lblTimer2.Enabled = true;
            lblNumeroCliente.Text = cliente.Id.ToString();
            lblNombreCliente.Text = cliente.Apellido +", "+ cliente.Nombre;
            lblTelefono.Text = cliente.Telefono;
            lblDireccion.Text = cliente.Direccion;

            lblNetoGravado.Text = negocio.Neto.ToString();
            lblIvaTotal.Text = negocio.Iva.ToString();
            lblTotal.Text = negocio.Total.ToString();
            rtbListadoOC.Text = negocio.GenerarFactura();

        }

        private void rtbListadoOC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lblTimer2_Click(object sender, EventArgs e)
        {
            lblTimer2.Text = DateTime.Now.ToString();
        }
    }
}
