using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;
using Comun;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("              TEST\n" + "Impresión de pruebas del sistema:\n" + "---------------------------------\n");
                /*
                #region Testeos
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
                    Producto pPrueba = new Producto(102, "Desinfectactante !", EFamilia.Desinfectante, 125.35, 50);
                }
                catch (StringInvalidoException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                #endregion
                */

                Console.ReadKey();

                #region CargaDePrueba
                Negocio negocioDamian = new Negocio();
                Producto p1 = new Producto(100, "Alcohol", EFamilia.Alcohol, 85.25);
                Producto p2 = new Producto(102, "Desinfectactante", EFamilia.Desinfectante, 125.35, 50);
                Producto p3 = new Producto(101, "Detergente", EFamilia.Detergente, 175.00, 20, "Magistral");


                Cliente c1 = new Cliente("Federico", "Davila", "33456789", 1, "French 123", "4244-4444");
                Cliente c2 = new Cliente("Mauricio", "Ceriza", "33123456", 2, "Berutti 456", "4244-5555");
                Cliente c3 = new Cliente("daniel", "livon", "35123456", 10, "alasd 1", "442+-");
               
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
                /*
                #region ManejoDeArchivo
                try
                {
                    //Negocio.Guardar(n);
                    Console.WriteLine("Archivo de Universidad guardado.");
                }
                catch (ArchivosException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                #endregion
                */
            }
            catch (Exception ex)
            {
                Console.WriteLine("SE PUDRIO LA MOMIA!!! : " + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
