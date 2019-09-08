using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ListaPaquetesInstanciadas()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }
        [TestMethod]
        public void PaquetesConMismoTrackingID()
        {
            Paquete paqueteUno = new Paquete("Avellaneda", "222-222-0000");
            Paquete paqueteDos = new Paquete("Ezeiza", "222-222-0000");
            Correo correo = new Correo();
            correo += paqueteUno;
            try
            {
                correo += paqueteDos;
                Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(TrackingIdRepetidoException));
            }
        }
    }
}
