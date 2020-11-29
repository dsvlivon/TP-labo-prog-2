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
            timer.Enabled = true;
            lblNumeroCliente.Text = cliente.Id.ToString();
            lblNombreCliente.Text = cliente.Apellido + ", " + cliente.Nombre;
            lblTelefono.Text = cliente.Telefono;
            lblDireccion.Text = cliente.Direccion;

            rtbListadoOC.Text = negocio.GenerarFactura();
            lblIvaTotal.Text = negocio.Iva.ToString();
            lblNetoGravado.Text = negocio.Neto.ToString();
            lblTotal.Text = negocio.Total.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }
    }
}
