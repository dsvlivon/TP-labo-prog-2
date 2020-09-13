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

namespace TP1___Calculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Ejecuta el metodo limpiar y reestablece la accesibilidad de los botones btnConvertirBinario y btnConvertirDecimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnConvertirAbinario.Enabled = true;
            btnConvertirAdecimal.Enabled = false;
        }

        /// <summary>
        /// Establece el lblResultado en "0" y todos los demas campos en ""
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            cmbOperador.Text = "";
            lblResultado.Text = "0";
        }
        /// <summary>
        /// llena la variable resultado con retorno del metodo Operar, luego lo convierte a string para mostrarlo por form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
        }

        /// <summary>
        /// instancia 2 objetos tipo Numero invocando al constructor Numero(string StrNumero) y luego asigna a txtResultado el retorno del metodo estatico Calculadora.Operar
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>retorna un double con el resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2,string operador)
        {
            double txtResultado;
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            txtResultado = Calculadora.Operar(num1, num2, operador);

            return txtResultado;
        }

        /// <summary>
        /// invoca al metodo Close() q a su vez invoca al metodo dispose()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// asigna a resultado con el retorno del metodo estatico Numero.DecimalBinario
        /// Luego cambia los permisos de accesos de los botones btnConvertirvAbinario y btnConvertirAdecimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirAbinario_Click(object sender, EventArgs e)
        {
            string resultado = Numero.DecimalBinario(lblResultado.Text);
            lblResultado.Text = resultado;
            btnConvertirAbinario.Enabled = false;
            btnConvertirAdecimal.Enabled = true;
        }

        /// <summary>
        /// asigna a resultado con el retorno del metodo estatico Numero.BinarioDecimal
        /// Luego cambia los permisos de accesos de los botones btnConvertirvAbinario y btnConvertirAdecimal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirAdecimal_Click(object sender, EventArgs e)
        {
            string resultado = Numero.BinarioDecimal(lblResultado.Text);
            lblResultado.Text = resultado;
            btnConvertirAbinario.Enabled = true;
            btnConvertirAdecimal.Enabled= false;
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
