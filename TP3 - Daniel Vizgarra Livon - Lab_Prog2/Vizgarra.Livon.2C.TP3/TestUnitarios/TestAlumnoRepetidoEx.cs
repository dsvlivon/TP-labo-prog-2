using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Abstractas;
using Clases_Instanciables;

namespace TestUnitarios
{
    [TestClass]
    public class TestAlumnoRepetidoEx
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestAlumnoRepetido()
        {
            //Arrange
            Universidad universidad = new Universidad();
                // public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            Alumno alumno = new Alumno(1, "bart", "simpson", "33333333", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);

            //Act
            _ = universidad + alumno;
            _ = universidad + alumno;
            //Assert - 

        }
    }
}
