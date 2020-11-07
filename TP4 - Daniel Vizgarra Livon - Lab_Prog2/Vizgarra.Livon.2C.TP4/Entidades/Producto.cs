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
        private EFamilia familia;

        #region Constructores

        public Producto()
        {
            
        }

        /// <summary>
        /// Constructor. Inicializa los atributos del producto. 
        /// </summary>
        /// <param name="codigo">Codigo único (PK) del producto en la base de datos.</param>
        /// <param name="descripcion">Descripción del producto.</param>
        /// <param name="stock">Stock disponible del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="familia"> enumerados con tipos de productos.</param>
        public Producto(int codigo, string descripcion, int stock, double precio, EFamilia familia)
        {
            this.codigo = codigo;
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;
            this.familia = familia;

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
        public EFamilia Familia
        { get { return this.familia;}}

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
            sb.AppendLine(String.Format("Familia: {0}", this.Familia));
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

        /*private int ValidarCodigo(string value)
        {
            int aux;
            Regex reg = new Regex(@"^[0-9]+$");
            if (int.TryParse(value, out aux) && value.Length <= 8 && reg.IsMatch(value))
            {
                return aux;
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }*/
        #endregion
    }
}