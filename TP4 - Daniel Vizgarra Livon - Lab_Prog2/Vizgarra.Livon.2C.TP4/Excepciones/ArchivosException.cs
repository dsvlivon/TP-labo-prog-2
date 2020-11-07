using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException: Exception
    {
        public ArchivosException() : this("No se pudo guardar el archivo.\n")
        {

        }

        /// <summary>
        /// constructor q recibe un mensaje por parametros
        /// </summary>
        /// <param name="message"></param>
        public ArchivosException(string message) : base(message)
        {

        }
    }
}
