using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Comun;

namespace PersistenciaDeDatos
{
    public class Moderador
    {
        /// <summary>
        /// Metodo generico que recibe un objeto y un enumerado para realizar una acción en la base de datos
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="accion"></param>
        public static void ModerarDB(object objeto, EAccionesABM accion)
        {
            if (objeto is Producto)
            {
                Producto p = (Producto)objeto;
                switch (accion)
                {
                    case (EAccionesABM.Crear):
                        ProductosDB.InsertProducto(p.Descripcion, p.Marca, p.Precio, p.Stock);
                        break;
                    case (EAccionesABM.Modificar):
                        ProductosDB.UpdateProducto(p.Descripcion, p.Marca, p.Precio, p.Stock);
                        break;
                    case (EAccionesABM.Borrar):
                        ProductosDB.DeleteProducto(p.Codigo);
                        break;
                    default:
                    break;
                }
            }
        }
    }
}