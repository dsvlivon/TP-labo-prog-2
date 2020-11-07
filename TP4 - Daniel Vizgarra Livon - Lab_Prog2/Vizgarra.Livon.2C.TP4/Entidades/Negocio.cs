
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
        private List<Producto> productos;
        private List<Venta> ventas;
        public event Action productosListChanged;

        /// <summary>
        /// Constructor, instancia los campos de tipo lista. 
        /// Asocia el evento de cambios en la tabla de productos para actualizar la lista.
        /// </summary>
        public Negocio()
        {
            this.productos = ProductosDB.SelectAll();
            ProductosDB.ProductosDBChanged += ActualizarListaProductos;
            this.ventas = new List<Venta>();
        }

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

        /// <summary>
        /// Verifica si un producto se encuentra en la lista de productos.
        /// </summary>
        /// <param name="negocio"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator ==(Negocio negocio, Producto producto)
        {
            foreach (Producto p in negocio.productos)
            {
                if (p.Codigo == producto.Codigo)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si un producto NO se encuentra en la lista de productos. 
        /// </summary>
        /// <param name="negocio"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(Negocio negocio, Producto producto)
        {
            return !(negocio == producto);
        }

        /// <summary>
        /// Genera una nueva venta.
        /// </summary>
        /// <param name="producto">Producto a Vender.</param>
        /// <param name="cantidad">Cantidad solicitada del producto.</param>
        public void Vender(Producto producto, int cantidad)
        {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);

            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta_{0}.bin", nuevaVenta.Fecha.ToString("ddMMyyyy_HHmmss")));
            Serializador<Venta>.SerializarABinario(nuevaVenta, ruta);
            ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), String.Format(@"Venta_{0}.xml", nuevaVenta.Fecha.ToString("ddMMyyyy_HHmmss")));
            Serializador<Venta>.SerializarAXml(nuevaVenta, ruta);
        }

        private void ActualizarListaProductos(AccionesDB accion)
        {
            this.Productos = ProductosDB.SelectAll();
        }

        /// <summary>
        /// Devuelve un string conteniendo la descripción breve de cada venta en la lista de ventas. 
        /// </summary>
        /// <returns></returns>
        public string ListarVentas()
        {
            List<Venta> ventasOrdenadas = this.ventas.OrderByDescending(x => x.Fecha).ToList();

            StringBuilder sb = new StringBuilder();
            foreach (Venta venta in ventasOrdenadas)
            {
                sb.AppendLine(venta.ObtenerDescripcion()));
            }

            return sb.ToString();
        }
    }
}
