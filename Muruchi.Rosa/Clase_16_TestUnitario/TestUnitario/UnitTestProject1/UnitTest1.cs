using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {
      Estacionamiento e = new Estacionamiento(101);

      Assert.IsNotNull(e.Autos); //modificca los comportamientos de la clase
     
    }

    [TestMethod]
    public void EspacioEstacionamientoIncorrecto()
    {
      Estacionamiento e = new Estacionamiento(101);
      Estacionamiento e2 = new Estacionamiento(0);

      if (e.EspacioDisponible !=101)
      {
        Assert.Fail("ESPACIO INCORRECTO {0}", e.EspacioDisponible);
      }

      Assert.AreNotEqual(e2.EspacioDisponible, 1); //

      if(e2.EspacioDisponible !=0)
      {
        Assert.Fail("Error limite inferior {0}", e2.EspacioDisponible);
      }
    }
    [TestMethod]
    public void agregarAutosEstacionamiento()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("JJJ111", ConsoleColor.Black);
      Auto a2 = new Auto("JJJ222", ConsoleColor.Green);
      Auto a3 = new Auto("JJJ333", ConsoleColor.Yellow);

      try
      {
        e += a1;
        e += a2;
        e += a3;

        Assert.Fail("Error");

      }
      catch(Exception ex)
      {
        Assert.IsInstanceOfType(ex,typeof(EstacionamientoLlenoException));
      }
    }
    [TestMethod]
    public void agregarAutoEspacioDisponible()
    {
      Estacionamiento e = new Estacionamiento(2);
      Auto a1 = new Auto("JJJ111", ConsoleColor.Black);
      Auto a2 = new Auto("JJJ222", ConsoleColor.Green);

      e += a1;
      Assert.AreEqual(e.EspacioDisponible, 1);
      e += a2;
      Assert.AreEqual(e.EspacioDisponible, 0);
    }
  }
}
