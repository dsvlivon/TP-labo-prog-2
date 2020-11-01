using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Alumno:Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        public enum EEstadoCuenta
        {
            AlDia,Deudor,Becado
        }
        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Alumno() : base()
        {
            this.claseQueToma = default(Universidad.EClases);
            this.estadoCuenta = default(EEstadoCuenta);
        }
        /// <summary>
        /// constructor que recibe 6 argumentos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad">es un enumerado de la clase base Persona</param>
        /// <param name="claseQueToma">es un enumerado de la clase Universidad</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// constructor q recibe 7 argumentos
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni">como string</param>
        /// <param name="nacionalidad">enumarado de la clase base persona</param>
        /// <param name="claseQueToma">enumerado de la clase Universidad</param>
        /// <param name="estadoCuenta">enumerado de esta clase</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga del Metodo ToString
        /// </summary>
        /// <returns> retorna un StringBuilder formateado a string con la informacion de:
        /// objeto tipo Persona + Alumno </returns>

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}\n", base.MostrarDatos());
            sb.AppendFormat("ESTADO DE CUENTA: {0}\n", this.estadoCuenta);
            sb.AppendFormat("{0}", this.ParticiparEnClase());

            return sb.ToString();
        }
        /// <summary>
        /// Sobrecarta del == q evalua si un Alumno posee asiste a una clase (curso) y q no su estado de cuenta no sea deudorr
        /// </summary>
        /// <param name="a">es un objeto del tipo alumno</param>
        /// <param name="clase">se pasa una clase para evaluar</param>
        /// <returns>retorna un bool T o F dependiendo de la comparacion</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// negacion de la comparacion alumno == clase
        /// </summary>
        /// <param name="a">es un objeto del tipo alumno</param>
        /// <param name="clase">se pasa una clase para evaluar</param>
        /// <returns>retorna un bool T o F dependiendo de la comparacion</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            if (a.claseQueToma != clase)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// sobrecarga del metdo ParticiparEnClase q imprime por pantalla la clase q asiste
        /// </summary>
        /// <returns> retorna un StringBuilder formateado a string </returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("TOMA CLASES DE: {0}", this.claseQueToma.ToString());

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
