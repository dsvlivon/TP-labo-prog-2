using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using Comun;
using ClasePrincipal;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("              TEST\n" + "Impresión de pruebas del sistema:\n" + "---------------------------------\n");

                #region Testeos De Excepciones
                /*
                try
                {
                    Cliente cPrueba = new Cliente("Daniel", "Vizgarra", "3x3456789", 1, "Alvear 123", "4244-4444");
                }
                catch (DniInvalidoExcepcion ex)
                {
                    Console.WriteLine(ex.Message);
                }
                try
                {
                    Producto pPrueba = new Producto(102, "Desinfectactante !", "Espadol", 125.35, 50);
                }
                catch (StringInvalidoException ex)
                {
                    Console.WriteLine(ex.Message);
                } */
                #endregion


                #region CargaDePrueba
                Negocio negocioDamian = new Negocio();
                Producto p1 = new Producto(100, "Alcohol", "As");
                Producto p2 = new Producto(102, "Desinfectactante", "Unilever", 125.35);
                Producto p3 = new Producto(101, "Detergente", "Magistral", 175.00, 20);
                

                Cliente c1 = new Cliente("Federico", "Davila", "33456789", 1, "French 123", "4244-4444");
                Cliente c2 = new Cliente("Mauricio", "Ceriza", "33123456", 2, "Berutti 456", "4244-5555");
                Cliente c3 = new Cliente("daniel", "Vizgarra", "35123456", 10, "alasd 1", "+54 11 4244-1111");
               
                negocioDamian += c1;
                negocioDamian += c2;
                negocioDamian += c3;
                foreach (Cliente c in negocioDamian.Clientes)
                {
                    Console.WriteLine(c.ToString());
                }
                negocioDamian += p1;
                negocioDamian += p2;
                negocioDamian += p3;

                foreach (Producto p in negocioDamian.Productos)
                {
                    Console.WriteLine(p.ToString());
                }
                #endregion
                
                #region ManejoDeArchivo
                /*
                try
                {
                    //Guardar(this string texto, string archivo)
                    //Negocio.Guardar(this.GenerarFactura(),"backup.txt");
                    Console.WriteLine("Archivo de Negocio guardado.");
                }
                catch (ArchivosException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                */
                #endregion
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("SE PUDRIO LA MOMIA!!! : " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
