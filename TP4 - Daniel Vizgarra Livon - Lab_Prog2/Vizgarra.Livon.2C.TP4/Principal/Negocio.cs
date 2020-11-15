
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using Comun;
using Entidades;
using PersistenciaDeDatos;
using Excepciones;


namespace ClasePrincipal
{
    public class Negocio
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Venta> ventas;
        public event Action ListChanged;


        #region Constructor
        public Negocio()
        {
            /* p probar sin DB
            //this.productos = new List<Producto>();
            //this.clientes = new List<Cliente>();
            */
            this.clientes = ClientesDB.SelectAll();
            this.productos = ProductosDB.SelectAll();
            this.ventas = new List<Venta>();

            /*            
            ProductosDB.ProductosDBChanged += ActualizarListaProductos;
            ClientesDB.ClientesDBChanged += ActualizarListaClientes;
            */
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
                this.ListChanged();
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
                this.ListChanged();
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
        #endregion 

        #region Metodos
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

        public static bool operator !=(Negocio n, Producto p)
        {
            return !(n == p);
        }

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

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static Negocio operator +(Negocio n, Cliente c)
        {
            if (n != c)
            {
                n.Clientes.Add(c);
                return n;
            }
            throw new RepetidoException();
        }

        public static Negocio operator +(Negocio n, Producto p)
        {
            if (n != p)
            {
                n.Productos.Add(p);
                return n;
            }
            throw new RepetidoException();
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);
        }

        public string GenerarFactura()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Venta item in this.Ventas.ToList())
            {
                sb.AppendLine(item.ObtenerDescripcion());
            }
            return sb.ToString();
        }

        public void ActualizarAListaProductos()
        {
            this.Productos = ProductosDB.SelectAll();
        }

        public void ActualizarAListaClientes()
        {
            this.Clientes = ClientesDB.SelectAll();
        }

        #endregion
    }
}
