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
        /// <summary>
        /// Metodo para agregar un nuevo objeto de tipo producto a la base de datos.
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param> 
        public static void InsertProducto(string descripcion, string marca, double precio, int stock)
        {   
            ProductosDB.Comando.CommandText = "INSERT INTO dbo.Productos " +
                "(descripcion, marca, stock, precio) VALUES (@descripcion, @marca, @stock, @precio);";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@descripcion", descripcion);
            ProductosDB.Comando.Parameters.AddWithValue("@marca", marca);
            ProductosDB.Comando.Parameters.AddWithValue("@precio", precio);
            ProductosDB.Comando.Parameters.AddWithValue("@stock", stock);
            ProductosDB.Ejecutar();
        }

        /// <summary>
        /// Metodo para actualiar un objeto de tipo producto a la base de datos
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="stock"></param>
        public static void UpdateProducto(string descripcion, string marca, double precio, int stock)
        {
            ProductosDB.Comando.CommandText = "UPDATE dbo.Productos " +
                "SET precio = @precio, stock = @stock, marca = @marca, descripcion = @descripcion WHERE descripcion = @descripcion";
           

            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@descripcion", descripcion);
            ProductosDB.Comando.Parameters.AddWithValue("@marca", marca);
            ProductosDB.Comando.Parameters.AddWithValue("@precio", precio);
            ProductosDB.Comando.Parameters.AddWithValue("@stock", stock);
            ProductosDB.Ejecutar();
        }
       
        /// <summary>
        /// metodo para borrar un producto de la base de datos
        /// </summary>
        /// <param name="codigo"></param>
        public static void DeleteProducto(int codigo)
        {
            ProductosDB.Comando.CommandText = "DELETE FROM dbo.Productos WHERE codigo = @codigo";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@codigo", codigo);
            ProductosDB.Ejecutar();
        }

        /// <summary>
        /// Metodo que permite realizar una carga masiva de objetos de tipo producto a la lista de productos
        /// </summary>
        /// <returns></returns>
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
                        string descripcion = sqlReader["descripcion"].ToString();
                        string marca = sqlReader["marca"].ToString();
                        int stock = Convert.ToInt32(sqlReader["stock"]);
                        double precio = Convert.ToDouble(sqlReader["precio"]);
                        int codigo = Convert.ToInt32(sqlReader["codigo"]);
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
