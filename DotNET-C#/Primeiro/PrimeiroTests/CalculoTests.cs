using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.Tests
{
    [TestClass()]
    public class CalculoTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            var a = 5;
            var b = 5;
            var resultado = 10;
            var calculo = new Calculo();
            var esperado = calculo.Soma(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 5;
            var b = 5;
            var resultado = 0;
            var calculo = new Calculo();
            var esperado = calculo.Subtracao(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 5;
            var b = 5;
            var resultado = 25;
            var calculo = new Calculo();
            var esperado = calculo.Multiplicacao(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 5;
            var b = 5;
            var resultado = 1;
            var calculo = new Calculo();
            var esperado = calculo.Divisao(a, b);

            Assert.AreEqual(esperado, resultado);
        }
    }
}