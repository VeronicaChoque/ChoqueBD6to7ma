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
            bolillero = new Bolillero();
            bolillero.bolillasAdentro = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            simulacion = new Simulacion();


        }
    }
}
