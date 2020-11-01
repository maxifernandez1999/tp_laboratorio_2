using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using EntidadesAbstractas;
using Excepciones;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestValidarDni()
        {
            string dni9caracteres = "954548569";
            string dniTexto = "15265as5";

            //Act y Assert
            Alumno alumno1 = new Alumno(1515, "Juan", "Perez", dniTexto, Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            Alumno alumno2 = new Alumno(1002, "Pepito", "Gil", dni9caracteres, Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
            //Assert.Fail("Sin excepción para DNI inválido: {0}.", dniComa);
            

        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestValidarNacionalidad()
        {
            string dniExtranjero = "20000356";
            string dniArgentino = "95000125";

            //Act y Assert
            Alumno alumno1 = new Alumno(1515, "Juan", "Perez", dniArgentino, Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            Alumno alumno2 = new Alumno(1002, "Pepito", "Gil", dniExtranjero, Persona.ENacionalidad.Extranjero, Universidad.EClases.Legislacion);
        }

        [TestMethod]
        public void TestValidarInstanciaColeccion()
        {
            //Act y Assert
            Profesor profesor = new Profesor(111, "Elpepe", "Etesech", "42356424", Persona.ENacionalidad.Argentino);
            Jornada jornada = new Jornada(Universidad.EClases.Laboratorio, profesor);
            Assert.IsNotNull(jornada.Alumnos);
        }
    }
}
