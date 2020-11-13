
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using ComiqueriaDataAccess;

namespace Entidades
{
    public class Negocio
    {
        private List<Cliente> clientes;
        private List<Producto> productos;
        private List<Venta> ventas;
        public event Action productosListChanged;

        #region Constructor
        public Negocio()
        {
            this.productos = new List<Producto>();
            this.clientes = new List<Cliente>();
            this.ventas = new List<Venta>();
            
            /*
            this.productos = ProductosDB.SelectAll();
            ProductosDB.ProductosDBChanged += ActualizarListaProductos;
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
                this.productosListChanged();
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
                this.productosListChanged();
            }
        }
        public List<Venta> Ventas
        {
            get
            {
                return this.ventas;
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
            throw new Exception("el cliente ya existe");
        }

        public static Negocio operator +(Negocio n, Producto p)
        {
            if (n != p)
            {
                n.Productos.Add(p);
                return n;
            }
            throw new Exception("el producto ya existe");//armar la excepcion p el caso
        }
        
        public void Vender(Producto producto, int cantidad)
        {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);

            /*
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta_{0}.bin", nuevaVenta.Fecha.ToString("ddMMyyyy_HHmmss")));
            Serializador<Venta>.SerializarABinario(nuevaVenta, ruta);
            ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta_{0}.xml", nuevaVenta.Fecha.ToString("ddMMyyyy_HHmmss")));
            Serializador<Venta>.SerializarAXml(nuevaVenta, ruta);
            */
        }
                
        public string ListarVentas()
        {
            List<Venta> ventasOrdenadas = this.ventas.OrderByDescending(x => x.Fecha).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (Venta venta in ventasOrdenadas)
            {
                sb.AppendLine(venta.ObtenerDescripcion());
            }

            return sb.ToString();
        }
        
        /*
        private void ActualizarListaProductos(AccionesDB accion)
        {
            this.Productos = ProductosDB.SelectAll();
        }
        */
        #endregion
    }
}
