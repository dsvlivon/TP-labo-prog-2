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
        public event Action ListChanged;
   
        private Thread t;
        public event ActualizarDB ActualizarLista;
        public delegate void ActualizarDB();


        #region Constructor
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

        #endregion

        #region Metodos
        public void Vender(Producto producto, int cantidad)
        {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);
        }

        public void ActualizarListaProductos()
        {
            this.Productos = ProductosDB.SelectAll();
        }

        public void ActualizarListaVentas()
        {
            this.Neto = 0;
            this.Ventas.Clear();
        }

        public string ListarVentas()
        {
            double netoGravado= 0;
            StringBuilder sb = new StringBuilder();
            foreach (Venta item in this.Ventas.ToList())
            {
                sb.AppendLine(item.ObtenerDescripcionCorta());
                total += item.PrecioFinal;
            }
            this.Neto = netoGravado;
            return sb.ToString();
        }

        public string GenerarFactura()
        {
            t = new Thread(DescontarStock);


            this.Iva = this.Neto - ((this.Neto * Negocio.porcentajeIva) / 100);
            this.Total= this.Neto+ iva;

            StringBuilder sb = new StringBuilder();
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
                try
                {
                    foreach (Venta ven in ventas)
                    {
                        foreach (Producto prod in productos)
                        {
                            if (ven.Cantidad <= prod.Stock)
                            {
                                prod.Stock -= ven.Cantidad;
                            }
                        }
                    }
                   
                }
                catch (Exception ex)
                {
                    throw new StockInsuficienteExcepcion("Error al tratar de obtener los productos de la base de datos", ex);
                }
            }
        }
        #endregion
    }
}

