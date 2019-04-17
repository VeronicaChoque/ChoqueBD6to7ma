using System;
using System.Collections.Generic;
using BolilleroCV;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Bolillero bolillero;
        Simulacion simulacion;

        [TestMethod]
        public void TestMethod1()
        {
            bolillero = new Bolillero(1);
  
            simulacion = new Simulacion();
            simulacion.Bolillero = bolillero;
            simulacion.CantidadSimulaciones =1000000;
            simulacion.jugada = new List<int>{1};

            simulacion.simularSinHilos();

            Assert.AreEqual(1000000,simulacion.CantidadAciertos);
        }
    }
}
