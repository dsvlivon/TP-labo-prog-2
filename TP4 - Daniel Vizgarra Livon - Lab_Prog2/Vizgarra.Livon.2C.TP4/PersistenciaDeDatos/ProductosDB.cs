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
        public static void InsertProducto(Producto p)
        {
            InsertProducto(p.Codigo, p.Descripcion, p.Marca, p.Precio, p.Stock);
        }

        public static void InsertProducto(int codigo, string descripcion, string marca, double precio, int stock)
        {//(codigo, descripcion, marca, precio, stock)
            
            ProductosDB.Comando.CommandText = "INSERT INTO dbo.Productos " +
                "(descripcion, marca, stock, precio, codigo) VALUES (@descripcion, @marca, @stock, @precio, @codigo);";
            ProductosDB.Comando.Parameters.AddWithValue("@codigo", codigo);
            ProductosDB.Comando.Parameters.AddWithValue("@descripcion", descripcion);
            ProductosDB.Comando.Parameters.AddWithValue("@marca", marca);
            ProductosDB.Comando.Parameters.AddWithValue("@precio", precio);
            ProductosDB.Comando.Parameters.AddWithValue("@stock", stock);
            ProductosDB.Ejecutar();
            //invoke del evento q usa un delegado tipo 'ProductoDBDelegate' que recibe un 'enum EAccionesDB'
        }

        public static void UpdateProducto(Producto p)
        {
            UpdateProducto(p.Codigo, p.Descripcion, p.Marca, p.Precio, p.Stock);
        }

        public static void UpdateProducto(int codigo, string descripcion, string marca, double precio, int stock)
        {
            ProductosDB.Comando.CommandText = "UPDATE dbo.Productos SET precio = @nuevoPrecio WHERE codigo = @codigo";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@descripcion", descripcion);
            ProductosDB.Comando.Parameters.AddWithValue("@marca", marca);
            ProductosDB.Comando.Parameters.AddWithValue("@precio", precio);
            ProductosDB.Comando.Parameters.AddWithValue("@stock", stock);
            ProductosDB.Ejecutar();
            //invoke del evento q usa un delegado tipo 'ProductoDBDelegate' que recibe un 'enum EAccionesDB'
        }

        public static void DeleteProducto(int codigo)
        {
            ProductosDB.Comando.CommandText = "DELETE FROM dbo.Productos WHERE codigo = @codigo";
            ProductosDB.Comando.Parameters.Clear();
            ProductosDB.Comando.Parameters.AddWithValue("@codigo", codigo);
            ProductosDB.Ejecutar();
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
