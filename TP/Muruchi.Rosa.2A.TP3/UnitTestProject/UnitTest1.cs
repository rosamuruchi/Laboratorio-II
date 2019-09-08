using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EntidadesAbstractas;
using EntidadesInstanciables;
using Archivos;
using Excepciones;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarExceptionNacionalidadInvalida()
        {
            Universidad universidad = new Universidad();
            try
            {
                Alumno alumno = new Alumno(1, "Maria", "Gomez", "12345678", Persona.ENacionalidad.Extranjero,Universidad.EClases.SPD);
                universidad += alumno;
                Assert.Fail("Deberia avisar que la nacionalidad es invalida ");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }
        [TestMethod]
        public void ValidarAlumnoRepetidoException()
        {
            Universidad universidad = new Universidad();
            Alumno alumnoUno = new Alumno(2, "Juan", "Gutierrez", "53698745", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            universidad += alumnoUno;
            Alumno alumnoDos = new Alumno(2, "Romina", "Martinez", "36585820", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);

            try
            {
                universidad += alumnoDos;
                Assert.Fail("Deberia avisar que el alumno es repetido");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }
        }

        [TestMethod]
        public void ValidarDniInvalidoException()
        {
            Universidad universidad = new Universidad();
            try
            {
                Alumno alumno = new Alumno(8, "Rocio", "Montes", "-1k283387", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio, Alumno.EEstadoCuenta.Deudor);
                universidad += alumno;
                Assert.Fail("Deberia avisar que el dni es invalido");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        }


        [TestMethod]
        public void ValidarValoresNulos()
        {
            Universidad universidad = new Universidad();
            Alumno alumno = new Alumno(3, "sergio", "Ferru", "21171211", Persona.ENacionalidad.Argentino, Universidad.EClases.SPD);
            Profesor profesor = new Profesor(9, "luis", "Gonzalez", "54232356", Persona.ENacionalidad.Argentino);

            Assert.IsNotNull(universidad);
            Assert.IsNotNull(universidad.Instructores);
            Assert.IsNotNull(universidad.Jornadas);
            Assert.IsNotNull(universidad.Alumnos);
            Assert.IsNotNull(profesor);
            Assert.IsNotNull(alumno);
        }
    }
}
