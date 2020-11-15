using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class RepetidoException : Exception
    {
        public RepetidoException() : this("Este registro ya existe, no se puede Repetir.\n")
        {

        }

        /// <summary>
        /// constructor q recibe un mensaje por parametros
        /// </summary>
        /// <param name="message"></param>
        public RepetidoException(string message) : base(message)
        {

        }
        public RepetidoException(string message, Exception InnerException) : base(message)
        {

        }
    }
}
