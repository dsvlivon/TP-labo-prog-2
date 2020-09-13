using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
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
