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
