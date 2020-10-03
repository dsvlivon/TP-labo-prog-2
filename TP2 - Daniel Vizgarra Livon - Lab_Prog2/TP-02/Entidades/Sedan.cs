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

        #region "Constructores"
        /// <summary>
        /// Por defecto, TIPO será (Davila indico corregir "CuatroPuertas" a Monovolumen)!!!
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>       
        public Sedan(EMarca marca, string chasis, ConsoleColor color): this(marca, chasis,color, ETipo.Monovolumen)
        {
            //constructor d clase c/ 3 argumentos. this(4 argumentos) lo declara monovolumen
        }
        
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo atipo): base(chasis, marca, color)
        {
            tipo = atipo;
            //este lo toma c/ 4 argumentos y llama el constructor base (Vehiculo) y completa los 3 q ya sabe. 
        }
        #endregion

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
        /// <summary>
        /// Publica todos los datos del Vehiculo + datos del tipo Sedan
        /// </summary>
        /// <returns></returns>
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
