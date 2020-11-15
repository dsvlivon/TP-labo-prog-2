using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public interface IArchivoTexto
    {
        string Texto { get; }
        string Ruta { get; }
    }
}