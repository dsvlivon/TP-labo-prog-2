using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public class Delegados
    {
        public delegate void DBDelegate(EAccionesDB accion);
        public static event DBDelegate DBChanged;
    }
}
