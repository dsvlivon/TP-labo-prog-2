using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region Propiedades
        public List<Alumno> Alumnos 
        { 
            get 
            { 
                return this.alumnos; 
            } 
            set 
            { 
                this.alumnos = value; 
            } 
        }
        public Universidad.EClases Clase 
        { 
            get 
            { 
                return this.clase; 
            } 
            set 
            { 
                this.clase = value; 
            } 
        }
        public Profesor Instructor 
        { 
            get 
            { 
                return this.instructor; 
            } 
            set 
            { 
                this.instructor = value; 
            } 
        }
        #endregion


        #region Constructores
        /// <summary>
        /// Constructor por defecto q inicializa la lista d laumnos
        /// </summary>
        private Jornada()
        {
            alumnos = new List<Alumno>();
        }

        /// <summary>
        /// COnstructor con parametros q iniciliza los otros campos
        /// </summary>
        /// <param name="clase">clase</param>
        /// <param name="instructor">profesor</param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.Instructor = instructor;
            this.Clase = clase;
        }
        #endregion

        #region Metdos
        /// <summary>
        /// metodo para guardar un archivo 
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns> invocaicon del metodo guardar el archivo "Jornada.txt" en el directorio: escritorio</returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto txt = new Texto();
            return txt.Guardar(string.Format("{0}\\Jornada.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), jornada.ToString());
        }
        /// <summary>
        /// metodo para leer datos de un archivo en un directorio especifico
        /// </summary>
        /// <returns> una variable c el contenido leido </returns>
        public static string Leer()
        {
            Texto txt = new Texto();
            string datos = string.Empty;

            txt.Leer(string.Format("{0}\\Jornada.txt", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), out datos);

            return datos;

        }

        /// <summary>
        /// sobrecarga del metdo ToString
        /// imprime los datos de la jornada + clase+ profesor + lista d alumnos
        /// </summary>
        /// <returns> retorna un  stringbuilder formateado a string </returns>
        public override string ToString()
        {
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("JORNADA:");
                sb.AppendFormat("CLASE DE {0}: ", this.clase.ToString());
                sb.AppendFormat("POR {0}\n", this.instructor.ToString());
                sb.AppendLine("ALUMNOS:");
                foreach (Alumno alumno in this.alumnos)
                {
                    sb.AppendLine(alumno.ToString());
                }

                return sb.ToString();
            }
        }
        /// <summary>
        /// sobrecarga del operador de comparacion q verifica si el alumno parciticpa en la jornada
        /// </summary>
        /// <param name="j"> es un objeto del tipo jornada </param>
        /// <param name="a"> es un objeto del tipo alumno </param>
        /// <returns> retorna T o F dependiendo del resultado </returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            if (j.Alumnos.Contains(a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// negacion de la comparacion jornada == alumno
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns> retorna T o F dependiendo del resultado </returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        /// <summary>
        /// sobrecarga del operador + para agregar un alumno a la lista de la jornada
        /// </summary>
        /// <param name="j"> objeto de tipo Jornada </param>
        /// <param name="a"> objeto de tipo Alumno </param>
        /// <returns> la jornada c la adicion del alumno. caso contrario lanza una expecion </returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
                return j;
            }
            throw new AlumnoRepetidoException();
        }


        #endregion
    }
}
