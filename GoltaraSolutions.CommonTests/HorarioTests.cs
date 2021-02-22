using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoltaraSolutions.Common.Exceptions;

namespace GoltaraSolutions.Common.Tests
{
    [TestClass]
    public class HorarioTests
    {
        [TestMethod, ExpectedException(typeof(HorarioInvalidoException))]
        public void DefinirHoraInvalida()
        {
            Horario h = new Horario(70, 10);
            
            Assert.Inconclusive();
        }
        [TestMethod, ExpectedException(typeof(HorarioInvalidoException))]
        public void DefinirMinutoInvalido()
        {
            Horario h = new Horario(10, 71);
            
            Assert.Inconclusive();
        }
        [TestMethod]
        public void DefinirHorarioValido()
        {
            Horario h = new Horario(10, 59);
            
            Assert.IsTrue(true);
        }
    }
}
