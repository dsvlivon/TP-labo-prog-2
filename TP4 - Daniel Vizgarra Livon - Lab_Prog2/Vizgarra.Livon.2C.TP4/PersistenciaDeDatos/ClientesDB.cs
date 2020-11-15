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
    public class ClientesDB : DatabaseConnection
    {
        public delegate void DBDelegate(EAccionesDB accion);
        public static event DBDelegate DBChanged;

        public static void InsertCliente(int id, string nombre, string apellido, string dni, string direccion, string telefono)
        {
            ClientesDB.Comando.CommandText = "INSERT INTO dbo.Clientes " +

                "(id, nombre, apellido, dni, descripcion, telefono, dni) VALUES (@id, @nombre, @apellido, @dni, @direccion, @telefono);";
            ClientesDB.Comando.Parameters.Clear();
            ClientesDB.Comando.Parameters.AddWithValue("@id", id);
            ClientesDB.Comando.Parameters.AddWithValue("@nombre", nombre);
            ClientesDB.Comando.Parameters.AddWithValue("@apellido", apellido);
            ClientesDB.Comando.Parameters.AddWithValue("@dni", dni);
            ClientesDB.Comando.Parameters.AddWithValue("@descripcion", direccion);
            ClientesDB.Comando.Parameters.AddWithValue("@telefono", telefono);
            ClientesDB.Ejecutar();
            DBChanged.Invoke(EAccionesDB.Insert);
            //invoke del evento del tipo ProductoDBDelegate que recibe un enum EAccionesDB
        }

        public static void UpdateProducto(string nombre, string apellido, string dni, string direccion, string telefono)
        {
            ClientesDB.Comando.CommandText = "UPDATE dbo.Productos SET precio = @nuevoPrecio WHERE codigo = @codigo";
            ClientesDB.Comando.Parameters.Clear();
            ClientesDB.Comando.Parameters.AddWithValue("@nombre", nombre);
            ClientesDB.Comando.Parameters.AddWithValue("@apellido", apellido);
            ClientesDB.Comando.Parameters.AddWithValue("@dni", dni);
            ClientesDB.Comando.Parameters.AddWithValue("@descripcion", direccion);
            ClientesDB.Comando.Parameters.AddWithValue("@telefono", telefono);
            ClientesDB.Ejecutar();
            DBChanged.Invoke(EAccionesDB.Update);
            //invoke del evento del tipo ClientesDBDelegate que recibe un enum EAccionesDB
        }

        public static void DeleteProducto(int id)
        {
            ClientesDB.Comando.CommandText = "DELETE FROM dbo.Productos WHERE id = @id";
            ClientesDB.Comando.Parameters.Clear();
            ClientesDB.Comando.Parameters.AddWithValue("@id", id);
            ClientesDB.Ejecutar();
            DBChanged.Invoke(EAccionesDB.Delete);
        }

        public static List<Cliente> SelectAll()
        {
            List<Cliente> clientesLista = new List<Cliente>();

            try
            {
                ClientesDB.Comando.CommandText = "SELECT * FROM dbo.Clientes";

                ClientesDB.Conexion.Open();
                SqlDataReader sqlReader = ClientesDB.Comando.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {
                        int id = Convert.ToInt32(sqlReader["id"]);
                        string nombre = sqlReader["nombre"].ToString();
                        string apellido = sqlReader["apellido"].ToString();
                        string dni = sqlReader["dni"].ToString();
                        string direccion = sqlReader["direccion"].ToString();
                        string telefono = sqlReader["telefono"].ToString();

                        Cliente item = new Cliente(nombre, apellido, dni, id, direccion, telefono);
                        clientesLista.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArchivosException("Error al tratar de obtener los productos de la base de datos", ex);
            }
            finally
            {
                if (ClientesDB.Conexion.State == System.Data.ConnectionState.Open)
                {
                    ClientesDB.Conexion.Close();
                }
            }
            return clientesLista;
        }
    }
}
