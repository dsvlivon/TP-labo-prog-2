using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// constructor q recibe 2 argumetos, un mensaje por defecto y una innerException
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException) : base("Error de Archivos.", innerException)
        {

        }
    }
}
