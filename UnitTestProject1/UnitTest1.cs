using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProyectoPromedio;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConjuntoConNumerosPositivos()
        {
            int[] conjunto =  { 1, 2, 3, 4, 5 };
            double actual = calcularPromedio.calPromedio(conjunto); 
            double esperado = 3;
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void TestConjuntoConNumerosNegativos()
        {
            int[] conjunto = { -1, -2, -3, -4, -5 };
            double actual = calcularPromedio.calPromedio(conjunto);
            double esperado = -3;
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void TestConjuntoMixto()
        {
            int[] conjunto = { -1, 2, -3, 4, -5 };
            double actual = calcularPromedio.calPromedio(conjunto);
            double esperado = -0.6;
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void TestConjuntoConUnSoloElemento()
        {
            int[] conjunto = { 42 };
            double actual = calcularPromedio.calPromedio(conjunto);
            double esperado = 42;
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void TestConjuntoConValoresRepetidos()
        {
            int[] conjunto = new int[] { 5, 5, 5, 5, 5 };
            double actual = calcularPromedio.calPromedio(conjunto);
            double esperado = 5;
            Assert.AreEqual(esperado, actual);
        }
    }
}
