using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(string strNumero)
        {
            SetNumero = strNumero;
        }

        public Numero(double numero)
        {
            SetNumero = numero.ToString();
        }

        private double ValidarNumero(string strNumero)
        {
            double value=0;
            if(!double.TryParse(strNumero, out value))
            {
                value = 0;
            }
            return value;
        }

        public string SetNumero
        {
            set
            {
                this.numero = ValidarNumero(value);
            }
        }

        /// <summary>
        /// verifica que los valores recibidos sean '0' o '1'
        /// </summary>
        /// <param name="binario"></param>
        /// <returns> devueve un bool true o false si encuentra otro numero</returns>
        private static bool EsBinario(string binario)
        {            
            bool retorno=false;
         
            foreach (char item in binario)
            {
                if (item == '0' || item == '1')
                {
                    retorno = true;
                }
                else
                    retorno = false;
            }
            return retorno;
        }

        /// <summary>
        /// valida q el double recibido se mayor a 0 y lo convierte a base 2 binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Devuelve un string con el numero convertido, caso contrario devuelve "valor invalido"</returns>
        public static string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";
            if(numero>0)
            {
                Int64 aux = Convert.ToInt64(Math.Abs(numero));
                retorno = Convert.ToString(aux, 2);
            }
            return retorno;
        }

        /// <summary>
        /// si el string recibido puede ser convertido a numero, utiliza el valor convertido para invocar al metodo DecilmalBinario(double numero)
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Devuelve un string con el numero convertido, caso contrario devuelve "valor invalido"</returns>
        public static string DecimalBinario(string numero)
        {
            string retorno;

            if(double.TryParse(numero, out double value))
            {
                retorno = DecimalBinario(value);
            }
            else
            {
                retorno = "Valor Invalido";
            }
            return retorno;
        }

        /// <summary>
        /// Verifica si el string recibido es un binario, invocadno al metodo EsBinario(string binario)
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Devuelve un string con el numero convertido, caso contrario devuelve "valor invalido"</returns>
        public static string BinarioDecimal(string binario)
        {
            string retorno;
            if(EsBinario(binario))
            {
                retorno = Convert.ToInt64(binario, 2).ToString();
            }
            else
            {
                retorno = "Valor Invalido";
            }
            return retorno;
        }

        /// <summary>
        /// sobrecarga del operador '-' q permite restar los campos numero(double) de 2 objetos tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna el resultado matematico de esa operacion</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador '+' q permite sumar los campos numero(double) de 2 objetos tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna el resultado matematico de esa operacion</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// sobrecarga del operador '*' q permite multiplicar los campos numero(double) de 2 objetos tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retorna el resultado matematico de esa operacion</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Verifica si el valor double recibido es '0' y sobrecarga del operador '/' q permite dividir los campos numero(double) de 2 objetos tipo Numero
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>retornara "el doble del minimo permitido" o caso contrario el resultado matematico de esa operacion</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero==0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }
    }
}
