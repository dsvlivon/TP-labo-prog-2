using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// constructor que recibe un mensjae por defecto
        /// </summary>
        public NacionalidadInvalidaException() : this("Error de DNI/Nacionalidad...")
        {

        }

       /// <summary>
       /// constructor q recibe un mensaje por parametros
       /// </summary>
       /// <param name="message"></param>
        public NacionalidadInvalidaException(string message) : base(message)
        {

        }

    }
}
