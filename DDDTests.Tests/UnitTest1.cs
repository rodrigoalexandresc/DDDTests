using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DDDTests.Domain;

namespace DDDTests.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAbrirOrcamento()
        {
            var orcamento = new Orcamento("Rodrigo Alexandre", 100.00m, 3);

            Assert.IsNotNull(orcamento.DataDeAbertura);
            Assert.IsNull(orcamento.DataDeAprovacao);
            Assert.AreNotEqual(orcamento.Id, 0);
            Assert.IsNotNull(orcamento.Cliente);
        }
    }
}
