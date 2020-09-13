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

        private static bool EsBinario(string binario)
        {
            for(int i=0; i<binario.Length-1;i++)
            {
                if(binario[i]!='0' || binario[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

        /*/Los métodos BinarioDecimal y DecimalBinario convertirán el Resultado, 
        trabajarán con enteros positivos, quedándose para esto con el valor absoluto 
        y entero del double recibido:
        /*/
        public string DecimalBinario(double numero)
        {
            string retorno = "Valor invalido";
            if(numero>0)
            {
                Int64 aux = Convert.ToInt64(Math.Abs(numero));
                retorno = Convert.ToString(aux, 2);
                return retorno;
            }
            return retorno;
        }

        public string DecimalBinario(string numero)
        {
            string retorno;

            if(!EsBinario(numero))
            {
                retorno = "Valor Invalido";
            }
            else
            {
                retorno = DecimalBinario(numero);
            }
            return retorno;
        }

        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            if(n2.numero==0)//aca no m dejaba hacer n2==0 y tuve q acceder a n2.numero, será q en los anteriores es igual?
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
