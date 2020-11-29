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

                Negocio negocioPrueba = new Negocio();//al instanciar un objeto negocio, las 3 listas q tiene cargan los datos de la db                
                
                #region CargaDePrueba
                Cliente c1 = new Cliente("Diego", "Maradona", "33456789", 1001, "French 123", "4244-4444");
                Cliente c2 = new Cliente("Cliente de Prueba", "xxx", "33123456", 1111, "Berutti 456", "15 4244-5555");
                //Cliente cPrueba = new Cliente("Daniel", "Vizgarra", "3x3456789", 1031, "Alvear 123", "4244-4444");//erróneo

                negocioPrueba += c1;
                negocioPrueba += c2;
                Console.WriteLine(negocioPrueba.ListarClientes());
                negocioPrueba.Clientes.Remove(c2);
                Console.WriteLine("Remuevo el cliente de prueba\n");
                Console.WriteLine(negocioPrueba.ListarClientes());

                Producto p1 = new Producto(1002, "Desinfectactante", "Unilever", 125.35);
                Producto p2 = new Producto(1000, "Producto de Prueba", "xxx");
                //Producto pPrueba = new Producto(102, "Desinfectactante !", "Espadol", 125.35, 50);//erróneo  

                negocioPrueba += p1;
                negocioPrueba += p2;
                Console.WriteLine(negocioPrueba.ListarProductos());
                negocioPrueba -= p2;
                Console.WriteLine("Remuevo el producto de prueba\n");
                Console.WriteLine(negocioPrueba.ListarProductos());

                negocioPrueba.Vender(p1,3);
                negocioPrueba.Vender(p2, 4);
                
                Console.WriteLine(negocioPrueba.ListarVentas());      

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
            catch (DniInvalidoExcepcion ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Dni invalido"+"Presione una tecla p continuar");
                Console.ReadKey();
            }
            catch (TelefonoInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Telefono invalido" + "Presione una tecla p continuar");
                Console.ReadKey();
            }
            catch (RepetidoException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Repetido" + "Presione una tecla p continuar");
                Console.ReadKey();
            }
            catch (StringInvalidoException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("stringInvalid"+"Presione una tecla p continuar");
                Console.ReadKey();
            } /*
            catch (Exception ex)
            {
                Console.WriteLine("SE PUDRIO LA MOMIA!!! : " + ex.Message);
            }*/
            Console.ReadKey();
        }
    }
}
