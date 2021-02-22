using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoltaraSolutions.Common.Exceptions;

namespace GoltaraSolutions.Common.Tests
{
    [TestClass]
    public class PeriodoTests
    {
        [TestMethod]
        public void PeriodoValido()
        {
            Periodo p = new Periodo(new DateTime(2010,1,1), new DateTime(2016, 5, 1));
            Assert.IsTrue(true);
        }
        [TestMethod, ExpectedException(typeof(PeriodoInvalidoException))]
        public void PeriodoDataInicialInvalida()
        {
            Periodo p = new Periodo(new DateTime(), new DateTime(2016, 5, 1));
            Assert.Inconclusive();
        }
        [TestMethod, ExpectedException(typeof(PeriodoInvalidoException))]
        public void PeriodoDataFinalInvalida()
        {
            Periodo p = new Periodo(new DateTime(2016, 5, 1), new DateTime(2150, 1, 1));
            Assert.Inconclusive();
        }
        [TestMethod, ExpectedException(typeof(PeriodoInvalidoException))]
        public void PeriodoDataFinalMenorQueInicial()
        {
            Periodo p = new Periodo(new DateTime(2016, 5, 1), new DateTime());
            Assert.Inconclusive();
        }
    }
}
