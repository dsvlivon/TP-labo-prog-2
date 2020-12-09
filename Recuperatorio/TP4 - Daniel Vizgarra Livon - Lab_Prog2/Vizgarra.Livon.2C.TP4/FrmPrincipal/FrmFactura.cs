using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasePrincipal;
using Entidades;
using PersistenciaDeDatos;
using Comun;

namespace FrmPrincipal
{
    public partial class FrmFactura : Form, IGuardarFC
    {
        Cliente cliente;
        Negocio negocio;
        public FrmFactura(Negocio negocio, Cliente cliente)
        {
            this.cliente=  cliente;
            this.negocio = negocio;

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

            
            DialogResult answer = MessageBox.Show("VA A GUARDAR UN EXTRACTO TXT.", "Desea guardar la FC?", MessageBoxButtons.YesNo);
           

            if (answer == DialogResult.Yes)
            {
                MessageBox.Show("Extracto guardado exitosamente.");

                Thread t = new Thread(((IGuardarFC)this).GuardarFC);
                t.Start();
            }
        }
        /// <summary>
        /// Mantiene de dorma indefinida el funcionamiento del reloj.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        void IGuardarFC.GuardarFC()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(cliente.ToString());
            sb.AppendFormat("/n");
            sb.AppendFormat(negocio.GenerarFactura());
            
            Serializador<Negocio>.GuardarTxt(ruta, sb.ToString(), "Factura");
        }
    }
}