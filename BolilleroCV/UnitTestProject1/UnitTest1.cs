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

            //simulacion.simularSinHilos();      
            //Assert.AreEqual(1000000,simulacion.CantidadAciertos);

            simulacion.simularConHilos(4);
            Assert.AreEqual(4000000, simulacion.CantidadAciertos);
        }

        [TestMethod]
        public void pruebaBolillero()
        {
            bolillero = new Bolillero(10);
            List<int> jugada= new List<int>(){0,1};
            
            bolillero.jugar(jugada);
            Assert.IsFalse(bolillero.jugar(jugada));
            
            bolillero.sacarBolilla();
            Assert.IsFalse(bolillero.bolillasAfuera == null);
            //Assert.IsNotNull();

            bolillero.reingresarBolillas();

        }
    }
}
