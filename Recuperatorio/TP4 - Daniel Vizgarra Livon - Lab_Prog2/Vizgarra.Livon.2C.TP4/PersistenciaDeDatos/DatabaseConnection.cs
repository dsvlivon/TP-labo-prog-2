using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Excepciones;


namespace PersistenciaDeDatos 
{
    
    public abstract class DatabaseConnection
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        #region Constructores
        static DatabaseConnection()
        {
            conexion = new SqlConnection("Server=.\\SQLEXPRESS;Database=TP4;Trusted_Connection=True;");
            comando = new SqlCommand();
            comando.Connection = DatabaseConnection.conexion;
        }
        #endregion

        #region Propiedades
        protected static SqlConnection Conexion
        {
            get
            {
                return DatabaseConnection.conexion;
            }
        }

        protected static SqlCommand Comando
        {
            get
            {
                return DatabaseConnection.comando;
            }
        }
        protected static SqlDataReader Reader
        {
            get
            {
                return DatabaseConnection.Reader;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Metodo para establecer y finalizar la conexion con la base de datos, con orden try/catch/finally
        /// </summary>
        protected static void Ejecutar()
        {
            try
            {
                DatabaseConnection.Conexion.Open();
                DatabaseConnection.Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ArchivosException("Ocurrió un error en la base de datos.", ex);
            }
            finally
            {
                if (DatabaseConnection.Conexion.State == System.Data.ConnectionState.Open)
                {
                    DatabaseConnection.Conexion.Close();
                }
            }
        }
        #endregion
    }
}
