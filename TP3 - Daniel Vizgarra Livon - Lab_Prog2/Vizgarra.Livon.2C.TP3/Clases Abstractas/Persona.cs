using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarNombreApellido(value);
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }
        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }
        private string StringToDni
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona() : this(string.Empty, string.Empty, default(ENacionalidad))
        {
            this.dni = default;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = ValidarNombreApellido(nombre);
            this.Apellido = ValidarNombreApellido(apellido);
            this.Nacionalidad = nacionalidad;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.Dni = dni;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDni = dni;
        }

        #endregion

        #region Metodos
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (nacionalidad == ENacionalidad.Argentino)
            {
                //Argentino entre 1 y 89999999
                if (dato >= 1 && dato <= 89999999)
                {
                    return dato;
                }
            }
            else if (nacionalidad == ENacionalidad.Extranjero)
            {
                //Extranjero entre 90000000 y 99999999
                if (dato >= 90000000 && dato <= 99999999)
                {
                    return dato;
                }
            }
            throw new NacionalidadInvalidaException();
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int auxDato;
            Regex reg = new Regex(@"^[0-9]+$");
            if (int.TryParse(dato, out auxDato) && dato.Length <= 8 && reg.IsMatch(dato))
            {
                return ValidarDni(nacionalidad, auxDato);
            }
            else
            {
                throw new DniInvalidoException();
            }
        }

        private string ValidarNombreApellido(string dato)
        {
            string auxDato;
            Regex rx = new Regex(@"^[A-Z][a-z ]+$");
            if (rx.IsMatch(dato))
            {
                auxDato = dato;
            }
            else
            {
                auxDato = string.Empty;
            }
            return auxDato;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\r\n", this.Apellido, this.Nombre);
            sb.AppendFormat("NACIONALIDAD: {0}\n", this.Nacionalidad.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
