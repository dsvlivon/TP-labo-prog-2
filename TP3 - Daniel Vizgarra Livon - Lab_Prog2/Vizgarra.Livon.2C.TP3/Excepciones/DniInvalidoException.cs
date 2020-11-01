using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        /// <summary>
        /// Constructor con mensaje por defecto
        /// </summary>
        public DniInvalidoException() : this("El Dni ingresado es invalido")
        {

        }
        /// <summary>
        /// Constructor que recibe mensaje por parametro
        /// </summary>
        /// <param name="message">Mensaje</param>
        public DniInvalidoException(string message) : base(message)
        {

        }

       /// <summary>
       /// construcgtor q recibe 2 argumentos, un mensaje por defecto y una expcecion
       /// </summary>
       /// <param name="ex"></param>
        public DniInvalidoException(Exception ex) : this("El DNI ingresado es invalido", ex)
        {

        }

        /// <summary>
        /// constructor que recibe 2 argumentos, un mensaje por parametros y una excepcion
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public DniInvalidoException(string message, Exception ex) : base(message, ex)
        {

        }
    }
}
