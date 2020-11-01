using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public class Universidad
    {

        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }

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
        public List<Profesor> Instructores
        {
            get 
            {
                return this.profesores;
            }
            set 
            {
                this.profesores = value;
            }
        }
        public List<Jornada> Jornadas 
        {
            get 
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public Jornada this[int i] 
        { 
            get 
            { 
                return this.jornada[i]; 
            } 
            set 
            { 
                this.jornada[i] = value; 
            } 
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto que inicializa las listas
        /// </summary>
        public Universidad()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }
        #endregion
        // <summary>
        /// metodo para guardar un archivo 
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns> invocaicon del metodo guardar los datos del objeto "uni" recibido x parametros.
        /// en el archivo "Universidad.xml" en el directorio: escritorio</returns>
        #region Metodos
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            return xml.Guardar(string.Format("{0}\\Universidad.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), uni);
        }

        /// <summary>
        /// metodo para leer datos de un archivo en un directorio especifico
        /// </summary>
        /// <returns> una variable c el contenido leido </returns>
        public static Universidad Leer()
        {
            Xml<Universidad> xml = new Xml<Universidad>();
            Universidad universidad = new Universidad();

            xml.Leer(String.Format("{0}\\Universidad.xml", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), out universidad);
            return universidad;
        }
        /// <summary>
        /// Sobrecarga del metdo MostrarDatos
        /// </summary>
        /// <param name="uni"></param>
        /// <returns> retora un stringBuilder formateado a string con los datos de la lista jornada del objeto uni </returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jornada jornada in uni.Jornadas)
            {
                sb.AppendLine(jornada.ToString());
                sb.AppendLine("<------------------------------------->");
            }
            return sb.ToString();
        }
        /// <summary>
        /// sobrecarga del operador de comparacion Universidad == Alumno
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns> retorna bool T o F dependiendo del resultado </returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Negacion de la comparacion Universidad == Alumno
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns> retorna bool T o F dependiendo del resultado </returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g==a);
        }
        /// <summary>
        /// sobrecarga del operador de comparacion Universidad == Profesor
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns> retorna bool T o F dependiendo del resultado </returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor profesor in g.profesores)
            {
                if (profesor == i)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Negacion de la comparacion Universidad == Profesor
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns> retorna bool T o F dependiendo del resultado </returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Sobrecarga el operador de comparacion Universidad == EClases clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns> retorna bool T o F dependiendo del resultado </returns>
        public static Profesor operator ==(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == clase)
                {
                    return profesor;
                }
            }
            
            throw new SinProfesorException();
        }

        /// <summary>
        /// Negacion de la comparacion Universidad == clase
        /// </summary>
        /// <param name="u"></param>
        /// <param name="clase"></param>
        /// <returns> retorna bool T o F dependiendo del resultado </returns>

        public static Profesor operator !=(Universidad u, EClases clase)
        {
            foreach (Profesor profesor in u.Instructores)
            {
                if (profesor == clase)
                {
                    return profesor;
                }
            }
            throw new SinProfesorException();
        }
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {
            Profesor profesor = g == clase; //esto no lo sabia...
            Jornada jornada = new Jornada(clase, profesor);
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == clase)
                {
                    jornada += alumno;
                }
            }
            g.Jornadas.Add(jornada);
            return g;

        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
                return u;
            }
            throw new AlumnoRepetidoException();
        }

        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)//gracias a la sobrecarga del ==0
            {
                u.Instructores.Add(i);
            }
            return u;
        }
        #endregion
    }
}
