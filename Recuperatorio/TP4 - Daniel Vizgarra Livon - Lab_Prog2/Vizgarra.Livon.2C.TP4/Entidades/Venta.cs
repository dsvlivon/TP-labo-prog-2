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
        public Venta(Producto producto, Cliente cliente, int cantidad)
        {
            this.cliente = cliente;
            this.producto = producto;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
            this.cantidad = ValidarStock(cantidad);
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
                this.cantidad = ValidarStock(value);
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
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set
            {
                this.cliente = value;
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
        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            return precioUnidad * cantidad;
        }

        public string ObtenerDescripcionCorta()
        {
            return String.Format("{0}   |   {1}    |    {2}    |   {3}", 
                this.producto.Descripcion, this.producto.Precio.FormatearPrecio(), this.Cantidad, this.precioFinal.FormatearPrecio()) ;
        }
        public string ObtenerDescripcionLarga()
        {
            return String.Format("{0}        |         {1}         |       {2}        |         {3}         |       {4}       |     {5}",
                this.producto.Codigo, this.producto.Descripcion, this.producto.Marca, this.producto.Precio.FormatearPrecio(), this.Cantidad, this.precioFinal.FormatearPrecio());
        }
        public int ValidarStock(int cant)
        {
            if(cant <= this.Producto.Stock)
            {
                return cant;
            }
            return this.Producto.Stock;
        }
        #endregion
    }
}
