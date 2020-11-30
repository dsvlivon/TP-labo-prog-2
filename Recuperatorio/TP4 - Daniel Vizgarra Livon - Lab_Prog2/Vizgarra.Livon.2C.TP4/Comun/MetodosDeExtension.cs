using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public static class MetodosDeExtension
    {

        /// <summary>
        /// Metodo de extensión q recibe un valor d precio calculado y lo retorna formateado
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string FormatearPrecio(this Double valor)
        {
            return String.Format("{0:0.00}$", valor);
        }
    }
}
