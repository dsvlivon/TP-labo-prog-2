using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CodigoInvalidoException : Exception
    {       
        /// <summary>
        /// constructor que recibe un mensjae por defecto
        /// </summary>
        public CodigoInvalidoException() : this("Error en el ingreso del codigo.\n" +
            "No utilice carácteres especiales, sólo números.")
        {

        }

        /// <summary>
        /// constructor q recibe un mensaje por parametros
        /// </summary>
        /// <param name="message"></param>
        public CodigoInvalidoException(string message) : base(message)
        {

        }
        public CodigoInvalidoException(string message, Exception innerException) : base(message)
        {

        }
    }
}
