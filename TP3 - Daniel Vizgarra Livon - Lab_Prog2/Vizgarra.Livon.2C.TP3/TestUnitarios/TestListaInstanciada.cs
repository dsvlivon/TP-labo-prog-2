using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Clases_Instanciables;
using Clases_Abstractas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitarios
{
    class TestListaInstanciada
    {
        [TestMethod]
        public void TestColeccion()
        {
            // Arange
            Universidad testUni = new Universidad();

            //Assert
            Assert.IsInstanceOfType(testUni.Alumnos, typeof(List<Alumno>));
            //Act
        }
    }
}
