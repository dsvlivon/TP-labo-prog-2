using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using Excepciones;
using Comun;

namespace PersistenciaDeDatos
{
    public class ProductosDB : DatabaseConnection
    {
        public delegate void DBDelegate(EAccionesDB accion);
        public static event DBDelegate DBChanged;

        public static void InsertProducto(string descripcion, double precio)
        {
            ProductosDB.Comando.CommandText = "INSERT INTO dbo.Productos " +
                "(codigo, descripcion, familia, precio) VALUES (@codigo, @descripcion, @famiia, @precio);";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@descripcion", descripcion);
            ProductosDB.Comando.Parameters.AddWithValue("@precio", precio);
            ProductosDB.Ejecutar();
            DBChanged.Invoke(EAccionesDB.Insert);
            //invoke del evento q usa un delegado tipo 'ProductoDBDelegate' que recibe un 'enum EAccionesDB'
        }

        public static void UpdateProducto(string descripcion, string marca,int stock, double precio)
        {
            ProductosDB.Comando.CommandText = "UPDATE dbo.Productos SET precio = @nuevoPrecio WHERE codigo = @codigo";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@descripcion", descripcion);
            ProductosDB.Comando.Parameters.AddWithValue("@marca", marca);
            ProductosDB.Comando.Parameters.AddWithValue("@nuevoPrecio", precio);
            ProductosDB.Comando.Parameters.AddWithValue("@stock", stock);
            ProductosDB.Ejecutar();
            DBChanged.Invoke(EAccionesDB.Update);
            //invoke del evento q usa un delegado tipo 'ProductoDBDelegate' que recibe un 'enum EAccionesDB'
        }

        public static void DeleteProducto(int codigo)
        {
            ProductosDB.Comando.CommandText = "DELETE FROM dbo.Productos WHERE codigo = @codigo";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@codigo", codigo);
            ProductosDB.Ejecutar();
            DBChanged.Invoke(EAccionesDB.Delete);
            //invoke del evento q usa un delegado tipo 'ProductoDBDelegate' que recibe un 'enum EAccionesDB'
        }

        public static List<Producto> SelectAll()
        {
            List<Producto> productosList = new List<Producto>();

            try
            {
                ProductosDB.Comando.CommandText = "SELECT * FROM dbo.Productos";

                ProductosDB.Conexion.Open();
                SqlDataReader sqlReader = ProductosDB.Comando.ExecuteReader();
                if(sqlReader.HasRows)
                { 
                    while (sqlReader.Read())
                    {
                        int codigo = Convert.ToInt32(sqlReader["codigo"]);
                        string descripcion = sqlReader["descripcion"].ToString();
                        string marca = sqlReader["marca"].ToString();
                        double precio = Convert.ToDouble(sqlReader["precio"]);
                        int stock = Convert.ToInt32(sqlReader["stock"]);
                        Producto producto = new Producto(codigo, descripcion, marca, precio, stock);
                        productosList.Add(producto);
                    }
                }
                
            }
            catch (Exception ex)
            {
                throw new ArchivosException("Error al tratar de obtener los productos de la base de datos", ex);
            }
            finally
            {
                if (ProductosDB.Conexion.State == System.Data.ConnectionState.Open)
                {
                    ProductosDB.Conexion.Close();
                }
            }
            return productosList;
        }
    }
}
