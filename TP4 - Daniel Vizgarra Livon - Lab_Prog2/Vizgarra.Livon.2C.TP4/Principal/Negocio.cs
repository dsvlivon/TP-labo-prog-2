using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Entidades;
using PersistenciaDeDatos;
using Excepciones;
using System.Threading.Tasks;
using System.Threading;

namespace ClasePrincipal
{
    public class Negocio
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Venta> ventas;
        private double total;
        private double iva;
        private double neto;
        private static int porcentajeIva;

       

        #region Constructor
        /// <summary>
        /// Constructor por defecto que instancia las 3 listas y setea el valor estatico iva
        /// </summary>
        public Negocio()
        {
            this.clientes = ClientesDB.SelectAll();
            this.productos = ProductosDB.SelectAll();
            this.ventas = new List<Venta>();
            Negocio.porcentajeIva = 21;
        }
        #endregion

        #region Propiedades

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }
        public List<Cliente> Clientes
        {
            get
            {
                return this.clientes;
            }
            set
            {
                this.clientes = value;
            }
        }
        public List<Venta> Ventas
        {
            get
            {
                return this.ventas;
            }
            set
            {
                this.ventas = value;
            }
        }
        public static int PorcentajeIva
        {
            get
            {
                return Negocio.PorcentajeIva;
            }
            set
            {
                Negocio.PorcentajeIva = porcentajeIva;
            }
        }
        public double Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }
        public double Neto
        {
            get
            {
                return this.neto;
            }
            set
            {
                this.neto = value;
            }
        }
        public double Iva
        {
            get
            {
                return this.iva;
            }
            set
            {
                this.iva = value;
            }
        }
        #endregion 

        #region Sobrecargas
        /// <summary>
        /// sobrecarga del == para comparar si un producto se encuentra en el inventario del negocio
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <returns> un bool </returns>
        public static bool operator ==(Negocio n, Producto p)
        {
            foreach (Producto item in n.productos)
            {
                if (item.Codigo == p.Codigo)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// sobrecarga del != para negar ==, el producto no esta en el inventario
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <returns> bool T o F </returns>
        public static bool operator !=(Negocio n, Producto p)
        {
            return !(n == p);
        }
        /// <summary>
        /// sobrecarga del == para comparar si un cliente se encuentra entre los clientes del negocio
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns> bool T o F </returns>
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente item in n.clientes)
            {
                if (item.Id == c.Id)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// sobrecarga del != para negar el ==, el cliente no esta en la lista del negocio
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns> bool T o F </returns>
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        /// <summary>
        /// sobrecarga del + para sumar un cliente a la lista, si este no estaba con anterioridad
        /// </summary>
        /// <param name="n"></param>
        /// <param name="c"></param>
        /// <returns> el objeto negocio modificado </returns>
        public static Negocio operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.Clientes.Add(c);
                return n;
            }
            throw new RepetidoException();
        }

        /// <summary>
        /// sobrecarga del + para sumar un producto a la lista, si este no estaba con anterioridad
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <returns> el objeto negocio modificado </returns>
        public static Negocio operator +(Negocio n, Producto p)
        {
            if (n != p)
            {
                n.Productos.Add(p);
                return n;
            }
            throw new RepetidoException();
        }
        public static Negocio operator -(Negocio n, Producto p)
        {
            if (n == p)
            {
                n.Productos.Remove(p);
                return n;
            }
            throw new RepetidoException();
        }

        /// <summary>
        /// sobrecarga del + para sumar una venta a la lista, si la venta contiene informacion
        /// </summary>
        /// <param name="n"></param>
        /// <param name="v"></param>
        /// <returns>  el objeto negocio modificado </returns>
        public static Negocio operator +(Negocio n, Venta v)
        {
            if (v != null)
            {
                n.Ventas.Add(v);
            }
            return n;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para instanciar una venta solo SI el producto contiene informacion y la cantidad a vender es mayor a 0
        /// no valido q el pregunto este en la lista, xq lo levanta de la BD
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        public void Vender(Producto producto, int cantidad)
        {
            if(producto != null && cantidad > 0)
            {
                Venta nuevaVenta = new Venta(producto, cantidad);
                this.ventas.Add(nuevaVenta);
            }
        }
        
        public void ActualizarListaProductos()
        {
            this.Productos = ProductosDB.SelectAll();
        }
        /// <summary>
        /// Metodo para anular y refrescar la venta en curso
        /// </summary>
        public void ActualizarListaVentas()
        {
            this.Neto = 0;
            this.Ventas.Clear();
        }
        /// <summary>
        /// Metodo para listar las ventas y Pisar el campo neto de la clase. 
        /// Utiliza el metodo DescripcionCorta y es usado solo en la generacion de orden de comrpa
        /// </summary>
        /// <returns> retorna un el objeto sb 'stringBuilder' ToString() </returns>
        public string ListarVentas()
        {
            double netoGravado= 0;
            StringBuilder sb = new StringBuilder();
            foreach (Venta item in this.Ventas.ToList())
            {
                sb.AppendLine(item.ObtenerDescripcionCorta());
                netoGravado += item.PrecioFinal;
            }
            this.Neto = netoGravado;
            return sb.ToString();
        }
        
        public string ListarClientes()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cliente item in this.Clientes)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string ListarProductos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Producto item in this.Productos)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        public string GenerarFactura()
        {
            this.Iva = (this.Neto * Negocio.porcentajeIva) / 100;
            this.Total= this.Neto + this.Iva;

            StringBuilder sb = new StringBuilder();
            
             
            sb.AppendFormat("Codigo     |     Descripcion     |      Marca       |    Precio un.    |    Cantidad     |     Subtotal\n");
            foreach (Venta item in this.Ventas.ToList())
            {
                sb.AppendLine(item.ObtenerDescripcionLarga());
            }
            
            return sb.ToString();
        }

        public void DescontarStock()
        {
           
            if (this.ventas != null)
            {
               
                foreach (Venta ven in ventas)
                {
                    foreach (Producto prod in productos)
                    {
                        if(ven.Producto.Codigo == prod.Codigo)
                        {
                                prod.Stock -= ven.Cantidad;
                        }
                    }
                }                   
               
            }
            
        }

       
        #endregion
    }
}

