using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class TelefonoInvalidoException : Exception
    {
        /// <summary>
        /// constructor que recibe un mensjae por defecto
        /// </summary>
        public TelefonoInvalidoException() : this("Error en la carga de datos.\n" +
            "Utilice sólo números con un '-' y un '+' si es necesario.")
        {

        }

        /// <summary>
        /// constructor q recibe un mensaje por parametros
        /// </summary>
        /// <param name="message"></param>
        public TelefonoInvalidoException(string message) : base(message)
        {

        }
    }
}
