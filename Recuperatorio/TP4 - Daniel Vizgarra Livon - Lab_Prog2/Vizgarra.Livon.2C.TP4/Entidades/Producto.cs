using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;
using Comun;

namespace Entidades
{
    [Serializable]
    public class Producto
    {
        private int stock;
        private double precio;
        private int codigo;
        private string descripcion;
        private string marca;

        #region Constructores
        public Producto()
        {
            
        }
        
        public Producto(int codigo, string descripcion, string marca)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.marca = marca;
            this.precio = 0;
            this.stock = 0;
        }

        public Producto(int codigo, string descripcion, string marca, double precio) 
            :this(codigo,descripcion,marca)
        {
            this.precio = precio;
        }

        public Producto(int codigo, string descripcion, string marca, double precio, int stock)
            : this(codigo, descripcion, marca, precio)
        {
            this.stock = stock;
        }
        public Producto(string descripcion, string marca,double precio, int stock)
        {
            this.descripcion = descripcion;
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Stock del producto. Debe ser mayor a cero. 
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        /// <summary>
        /// Precio del producto. Debe ser mayor a 1. 
        /// </summary>
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (value >= 1)
                {
                    this.precio = value;
                }
            }
        }

        /// <summary>
        /// Descripción del producto. 
        /// </summary>
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = ValidarString(value);
            }
        }


        /// <summary>
        /// Familia del producto. 
        /// </summary>
        public string Marca
        { 
            get 
            { 
                return this.marca;
            }
            set
            {
                this.marca = ValidarString(value);
            }
        }

        /// <summary>
        /// Código del producto en la base de datos (PK). 
        /// Propiedad de sólo lectura. 
        /// </summary>  
       
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Devuelve un string con los datos de un producto: código, descripción, precio y stock. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Código: {0}", this.Codigo));
            sb.AppendLine(String.Format("Descripción: {0}", this.Descripcion));
            sb.AppendLine(String.Format("Marca: {0}", this.marca));
            sb.AppendLine(String.Format("Precio: ${0:0.00}", this.Precio));
            sb.AppendLine(String.Format("Stock: {0} unidades", this.Stock));

            return sb.ToString();
        }

        public string ValidarString(string value)
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
        #endregion
    }
}