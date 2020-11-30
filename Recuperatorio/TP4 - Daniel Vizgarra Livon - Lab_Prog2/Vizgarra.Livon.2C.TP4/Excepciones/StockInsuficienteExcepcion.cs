using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class StockInsuficienteExcepcion : Exception
    {       
        /// <summary>
        /// constructor que recibe un mensjae por defecto
        /// </summary>
        public StockInsuficienteExcepcion() : this("Esta pidiendo mas unidades de las que hay en el inventario.\n")
        {

        }

        /// <summary>
        /// constructor q recibe un mensaje por parametros
        /// </summary>
        /// <param name="message"></param>
        public StockInsuficienteExcepcion(string message) : base(message)
        {

        }
        public StockInsuficienteExcepcion(string message, Exception innerException) : base(message)
        {

        }
    }
}
