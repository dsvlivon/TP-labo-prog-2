using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }
        /// <summary>
        /// constructor q incializa la cola y los randoms
        /// </summary>
        public Profesor() : base()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
            _randomClases();
        }
        /// <summary>
        /// constructor que recibe 5 argumentos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"> como string </param>
        /// <param name="nacionalidad"> es un enum d la clase persona </param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            _randomClases();
            _randomClases();
        }


        #endregion

        #region Metodos
        /// <summary>
        /// constructro por defecto
        /// </summary>
        private void _randomClases()
        {
            Universidad.EClases clase = (Universidad.EClases)random.Next(0, 3);
            clasesDelDia.Enqueue(clase);
        }

        /// <summary>
        /// sobrecarga del metodo ToString para qu
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClases clase in this.clasesDelDia)
            {
                sb.AppendLine(clase.ToString());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarga del Metodo ToString
        /// </summary>
        /// <returns> retorna un StringBuilder formateado a string con la informacion de:
        /// objeto tipo Persona + Profesor.ParticiparEnClase </returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}\n", base.MostrarDatos());
            sb.AppendFormat("{0}\n", this.ParticiparEnClase());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        /// <summary>
        /// Sobrecarga del operador == para comparar si un objeto Profesor participa en una determinada clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns> enumerado de la clase Universidad </returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            return i.clasesDelDia.Contains(clase);
        }

        /// <summary>
        /// negacion de la comparacion Profesor == Univeridad.EClase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion

    }
}
