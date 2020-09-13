using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida que se haya ingresado +,-,* o /, lo convierte 
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Devolvera como string el valor validado, caso contrario, devuelve "+"</returns>
        private static string ValidarOperador(char operador)
        {
            string retorno;
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            { 
                retorno= Convert.ToString(operador);
            }
            else
            { 
                retorno = "+";
            }
            return retorno;
        }

        /// <summary>
        /// Dependiendo del caso, realiza una operacion entre los valores de num1 y num1
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>devuelve como double el resultado de la operacion correspondiente</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double retorno;
            char operar;

            if (char.TryParse(operador, out operar))
            {
                switch (ValidarOperador(operar))
                {
                    case "+":
                        retorno = num1 + num2;
                        break;
                    case "-":
                        retorno = num1 - num2;
                        break;
                    case "*":
                        retorno = num1 * num2;
                        break;
                    case "/":
                        retorno = num1 / num2;
                        break;
                    default:
                        retorno = num1 + num2;
                        break;
                }
            }
            else
            {
                retorno = num1 + num2;
            }
            return retorno;
        }
    }

}
