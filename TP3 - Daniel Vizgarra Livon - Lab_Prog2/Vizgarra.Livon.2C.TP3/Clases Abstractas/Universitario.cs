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
        /// <summary>
        /// constructo por defecto
        /// </summary>
        public Universitario():base()
        {
            this.legajo = default; //esto no lo entiendo
        }
        /// <summary>
        /// contructor q recibe 5 parametros
        /// </summary>
        /// <param name="legajo"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad">es un enumerado</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :base(nombre,apellido,dni,nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo virtual para mostar los datos de base()Persona+Universitario
        /// </summary>
        /// <returns>retorna un StringBuider formateado a string</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}\n", base.ToString());
            sb.AppendFormat("LEGAJO NUMERO: {0}\n", this.legajo);

            return sb.ToString();
        }
        /// <summary>
        /// sobrecarga del metodo EQuals, 2 Universitarios seran iguales si coinciden Legajos O dni
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>Bool T o F dependiendo de la comparacion</returns>
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

        /// <summary>
        /// comparara segun el Equals  2 Universitarios
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>Bool T o F dependiendo de la comparacion</returns>
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
        /// <summary>
        /// Negacion de la comparacion universitario== universitario
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns>Bool T o F dependiendo de la comparacion</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1==pg2);
        }

        protected abstract string ParticiparEnClase();
        #endregion
    }
}
