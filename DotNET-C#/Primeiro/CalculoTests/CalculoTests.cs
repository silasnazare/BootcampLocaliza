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
            var a = 1;
            var b = 1;
            var esperado = 2;
            var calculo = new Calculo();
            var atual = calculo.Soma(a, b);

            Assert.AreEqual(esperado, atual);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            var a = 1;
            var b = 1;
            var esperado = 0;
            var calculo = new Calculo();
            var atual = calculo.Subtracao(a, b);

            Assert.AreEqual(esperado, atual);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            var a = 1;
            var b = 1;
            var esperado = 1;
            var calculo = new Calculo();
            var atual = calculo.Multiplicacao(a, b);

            Assert.AreEqual(esperado, atual);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            var a = 1;
            var b = 1;
            var esperado = 1;
            var calculo = new Calculo();
            var atual = calculo.Divisao(a, b);

            Assert.AreEqual(esperado, atual);
        }
    }
}