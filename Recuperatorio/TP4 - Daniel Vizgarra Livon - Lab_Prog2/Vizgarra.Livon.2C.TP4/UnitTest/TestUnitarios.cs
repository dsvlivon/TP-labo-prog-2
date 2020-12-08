using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using ClasePrincipal;
using Excepciones;


namespace UnitTest
{
    [TestClass]
    public class TestUnitarios
    {
        [TestMethod]
        public void DosclientesIguales()
        {
            //arrange
            bool resultado = false;
            Cliente c1 = new Cliente("Diego", "Maradona", "33456789", 1001, "French 123", "4244-4444");
            Cliente c2 = new Cliente("Lionel", "Messi", "33456789", 1001, "French 123", "4244-4444");
            //act
            if (c1 == c2)
            {
                resultado = true;
            }
            //assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void TestCargaListaDB()
        {
            // arrange
            Negocio negocioTest = new Negocio();
            bool resultado = false;

            // act
            if (!(negocioTest.Productos is null) && !(negocioTest.Productos is null))
            {
                resultado = true;
            }

            // assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void CargarListaVentas()
        {
            //arrange
            Negocio negocioTest = new Negocio();
            Cliente c1 = new Cliente("Diego", "Maradona", "33456789", 1001, "French 123", "4244-4444");
            Producto p1 = new Producto(1002, "Desinfectactante", "Unilever", 125.35);
            bool resultado = false;

            //act          
            negocioTest.Vender(p1, c1, 1);
            if (!(negocioTest.Productos is null))
            {
                resultado = true;
            }
            // assert
            Assert.IsTrue(resultado);
        }        
    }
}
