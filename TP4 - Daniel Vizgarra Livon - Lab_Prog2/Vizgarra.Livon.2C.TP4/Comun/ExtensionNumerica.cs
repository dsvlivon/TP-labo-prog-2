using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public static class ExtensionNumerica
    {
        public static string FormatearPrecio(this Double valor)
        {
            return String.Format("${0:0.00}", valor);
        }
    }
}
