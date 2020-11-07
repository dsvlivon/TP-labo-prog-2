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
    public sealed class Cliente : Persona
    {
        private int id;
        private string direccion;
        private string telefono;
        //private long cuilCuit;

        #region Constructores
        public Cliente()
        {

        }
        /// <summary>
        /// Constructor que recibe 4 parametros (solo id es obligatorio)
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="id"></param>
        public Cliente(string nombre, string apellido, string dni, int id)
           : base(nombre, apellido, dni)//public Persona(string nombre, string apellido, string dni)        
        {
            this.Id = id;
            this.Direccion = default;
            this.Telefono = default;
        }
        /// <summary>
        /// constructr que recibe 6 parametros. (completo)
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="id"></param>
        /// <param name="direccion"></param>
        /// <param name="telefono"></param>
        public Cliente(string nombre, string apellido, string dni, int id, string direccion, string telefono)
            :base(nombre, apellido, dni)//public Persona(string nombre, string apellido, string dni)        
        {
            this.Id = id;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }
        #endregion

        #region Propiedades
        public int Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        #endregion

        #region Metodos
        public override string ValidarString(string value)
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

        public string ValidarTelefono(string value)
        {
            string retorno = default;
            int contadorMas = 0;
            int contadorGuion = 0;
            Regex reg = new Regex(@"^[0-9]\+?\-?");
            if (reg.IsMatch(value))
            {
                //foreach (char c in value)
                for(int i=0; i<value.Length;i++)
                {
                    if(value[i] == '-')
                    {
                        contadorGuion++;
                    }
                    else if(value[i] == '+')
                    {
                        contadorMas++;
                    }
                }
                if (contadorMas <= 1 && contadorGuion <= 1)
                {
                    retorno = value;
                }
                return retorno;
            }

            else
            {
                throw new TelefonoInvalidoException();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n", base.ToString());
            sb.AppendFormat("Id Cliente: {0}\n", Id);
            sb.AppendFormat("Direccion: {1}\n", Direccion);
            sb.AppendFormat("Telefono: {2}\n", Telefono);

            return sb.ToString();
        }

        public static bool operator ==(Cliente a, Cliente b)
        {
            if (a.Dni == b.Dni || a.Id == b.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Cliente a, Cliente b)
        {
            return !(a == b);
        }
        #endregion
    }
}
