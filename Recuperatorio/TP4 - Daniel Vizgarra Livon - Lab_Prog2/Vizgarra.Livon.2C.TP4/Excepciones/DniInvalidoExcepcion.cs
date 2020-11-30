using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoExcepcion : Exception
    {
        /// <summary>
        /// constructor que recibe un mensjae por defecto
        /// </summary>
        public DniInvalidoExcepcion() : this("Error en la carga de datos.\n" +
            "Ingrese los numeros sin puntos ni comas.")
        {
            
        }

        /// <summary>
        /// constructor q recibe un mensaje por parametros
        /// </summary>
        /// <param name="message"></param>
        public DniInvalidoExcepcion(string message) : base(message)
        {

        }
    }
}
