using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoltaraSolutions.Common.Exceptions;

namespace GoltaraSolutions.Common.Tests
{
    [TestClass]
    public class DiasSemanaTests
    {
        [TestMethod]
        public void ValidarPeloMenosUmMarcado()
        {
            DiasSemana d = new DiasSemana();
            d.Segunda = true;
            d.ValidarPeloMenosUmMarcado();

            Assert.IsTrue(d.Segunda);
        }
        [TestMethod, ExpectedException(typeof(DiasSemanaInvalidoException))]
        public void ValidarNenhumMarcado()
        {
            DiasSemana d = new DiasSemana();
            d.ValidarPeloMenosUmMarcado();

            Assert.Inconclusive();
        }
    }
}
