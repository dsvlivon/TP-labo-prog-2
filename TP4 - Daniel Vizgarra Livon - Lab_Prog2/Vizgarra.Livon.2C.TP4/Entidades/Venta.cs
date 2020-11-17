using System;
using Comun;

namespace Entidades
{
    [Serializable]
    public sealed class Venta
    {
        private Producto producto;
        private Cliente cliente;
        private double precioFinal;
        private int cantidad;

        #region Constructores
        

        public Venta()
        {

        }
        public Venta(Producto producto, int cantidad)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
        }
        #endregion

        #region Propiedades
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
        public static double operator + (Venta a,Venta b)
        {
            return a.PrecioFinal + b.PrecioFinal;
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            return precioUnidad * cantidad;
        }

        public string ObtenerDescripcionCorta()
        {
            return String.Format("{0}   |   {1}    |    {2}    |   {3}\n", 
                this.producto.Descripcion, this.producto.Precio.FormatearPrecio(), this.Cantidad, this.precioFinal.FormatearPrecio()) ;
        }
        public string ObtenerDescripcionLarga()
        {
            return String.Format("{0}   |   {1}    |    {2}    |   {3}   |   {4}\n",
                this.producto.Codigo, this.producto.Descripcion, this.producto.Precio.FormatearPrecio(), this.Cantidad, this.precioFinal.FormatearPrecio());
        }
        #endregion
    }
}
