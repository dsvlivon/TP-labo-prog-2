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
    class TestNacionalidadInvalidaEx
    {
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalida()
        {
            Profesor profesor1 = new Profesor(1, "Seymour", "Skinner", "25364", Persona.ENacionalidad.Argentino);
            Profesor profesor2 = new Profesor(1, "Etna", "Krabaple", "25364", Persona.ENacionalidad.Extranjero);
        }
    }
}
