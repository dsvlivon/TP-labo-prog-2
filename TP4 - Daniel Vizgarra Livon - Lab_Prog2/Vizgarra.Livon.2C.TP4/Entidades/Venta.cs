using System;
using Comun;

namespace Entidades
{
    [Serializable]
    public sealed class Venta
    {
        private static int porcentajeIva;
        //private DateTime fecha;
        private Producto producto;
        private double precioFinal;
        private int cantidad;

        #region Constructores
        static Venta()
        {
            Venta.porcentajeIva = 21;
        }

        public Venta()
        {

        }
        public Venta(Producto producto, int cantidad)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.Vender(cantidad);
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }
        #endregion

        #region Propiedades
        public static int PorcentajeIva
        {
            get
            {
                return Venta.PorcentajeIva;
            }
            set
            {
                Venta.PorcentajeIva = porcentajeIva;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public Producto Producto
        {
            get
            {
                return this.producto;
            }
            set
            {
                this.producto = value;
            }
        }
        public double PrecioFinal
        {
            get
            {
                return this.precioFinal;
            }            
        }

        #endregion

        #region Metodos
        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            //this.fecha = DateTime.Now;
            //this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double subtotalSinIva = precioUnidad * cantidad;
            return subtotalSinIva + ((subtotalSinIva * Venta.porcentajeIva) / 100);
        }

        public string ObtenerDescripcion()
        {
            return String.Format("{0}   -   {1}    -    {2}    -   {3}   -   {4}\n", 
                this.producto.Codigo, this.producto.Descripcion, this.producto.Precio, this.Cantidad, this.precioFinal.FormatearPrecio()) ;
        }
        #endregion
    }
}
