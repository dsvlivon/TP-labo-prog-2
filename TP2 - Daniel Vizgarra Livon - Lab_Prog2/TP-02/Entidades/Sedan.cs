using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        public enum ETipo 
        { 
            Monovolumen, Sedan
        }
        ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será (Davila incico corregir "CuatroPuertas" a Monovolumen)!!!
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
       
        public Sedan(EMarca marca, string chasis, ConsoleColor color): this(marca, chasis,color, ETipo.Monovolumen)
        {

        }
        
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo atipo)
            : base(chasis, marca, color)
        {
            tipo = atipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
                /// Sedan son 'Mediano'
            }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("TIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
