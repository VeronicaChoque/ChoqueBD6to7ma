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
            bolillero = new Bolillero(50);         

            simulacion = new Simulacion();
            simulacion.Bolillero = bolillero;
            simulacion.CantidadSimulaciones =10;
            simulacion.jugada = new List<int> { 2, 4, 5 };

            simulacion.simularSinHilos();

            Assert.AreEqual(10,simulacion.CantidadAciertos);
            

        }
    }
}
