using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace Entidades
{
    [Serializable]
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
                
        #region Propiedades
        /// <summary>
        /// Propiedad que retorna el nombre si la validacion es correcta
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = ValidarString(value);
            }
        }
        /// <summary>
        /// Propiedad que retorna el apellido si la validacion es correcta
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarString(value);
            }
        }
        /// <summary>
        /// Propiedad que retorna el dni si la validacion es correcta
        /// </summary>
        public string Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(value).ToString();
            }
        }       
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Persona() 
        {

        }
        /// <summary>
        /// constructor que recibe 3 parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad">es un enumerable</param>
        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #endregion

        #region Metodos
       /// <summary>
       /// valida q el campo dni este dentro de los parametros esperados
       /// </summary>
       /// <param name="value"></param>
       /// <returns>retorna un integer con el valor comprobado</returns>
        private int ValidarDni(string value)
        {
            int auxValue;
            Regex reg = new Regex(@"^[0-9]+$");
            if (int.TryParse(value, out auxValue) && value.Length <= 8 && reg.IsMatch(value))
            {
                if(auxValue>14000000)
                {
                    return auxValue;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new DniInvalidoExcepcion();
            }
        }

        /// <summary>
        /// Valida q una cadena de string este dentro de los parametros esperados
        /// </summary>
        /// <param name="value"></param>
        /// <returns> la cadena validada </returns>
        public virtual string ValidarString(string value)
        {
            Regex reg = new Regex(@"^[A-Z][a-z ]+$");
            if (reg.IsMatch(value))
            {
                return value;
            }
            else
            {
                throw new StringInvalidoException();
            }
        }

        /// <summary>
        /// Sobrecarga del Metodo ToString
        /// </summary>
        /// <returns>retorna un StringBuilder formateado a string con la informacion de un objeto tipo persona</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}\r\n", this.Apellido, this.Nombre);
            sb.AppendFormat("DNI: {0}", this.dni);

            return sb.ToString();
        }
        #endregion
    }
}

