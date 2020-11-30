using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class StringInvalidoException : Exception
    {       
        /// <summary>
        /// constructor que recibe un mensjae por defecto
        /// </summary>
        public StringInvalidoException() : this("Error en la carga de datos.\n" +
            "No utilice carácteres especiales ni números.")
        {

        }

        /// <summary>
        /// constructor q recibe un mensaje por parametros
        /// </summary>
        /// <param name="message"></param>
        public StringInvalidoException(string message) : base(message)
        {

        }        
    }
}
