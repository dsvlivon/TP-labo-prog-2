using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Abstractas
{
    public abstract class Universitario:Persona
    {
        private int legajo;

        #region Constructores
        public Universitario():base()
        {
            this.legajo = default; //esto no lo entiendo
        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}\n", base.ToString());
            sb.AppendFormat("LEGAJO NUMERO: {0}\n", this.legajo);

            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if(obj is Universitario)
            {
                if ((this.legajo == ((Universitario)obj).legajo || this.Dni == ((Universitario)obj).Dni))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            /*if((getTypeOf(pg1)==getTypeOf(pg2)) && pg1.legajo==pg2.legajo || pg1.Dni == pg2.Dni)
            {
                return true;
            }
            return false;*/
            if (pg1.Equals(pg2))
            {
                return true;
            }
            return false;
           
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1==pg2);
        }

        protected abstract string ParticiparEnClase();
        #endregion
    }
}
