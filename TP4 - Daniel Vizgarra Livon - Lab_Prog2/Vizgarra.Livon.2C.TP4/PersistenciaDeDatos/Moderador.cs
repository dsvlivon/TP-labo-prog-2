using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PersistenciaDeDatos
{
    public class Moderador
    {      
        public static void GuardarDatosDB(object objeto)
        {
            if(objeto is Producto)
            {
                ProductosDB.InsertProducto((Producto)objeto);
            }
        }
        public static void ActualizarrDatosDB(object objeto)
        {
            if (objeto is Producto)
            {
                ProductosDB.UpdateProducto((Producto)objeto);
            }
        }
        public static void BorrarDatosDB(object objeto)
        {
            if (objeto is Producto)
            {
                Producto p = (Producto)objeto;
                ProductosDB.DeleteProducto(p.Codigo);
            }
        }

    }
}
