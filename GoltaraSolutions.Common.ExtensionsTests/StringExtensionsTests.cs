using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoltaraSolutions.Common.Extensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void IsNullOrEmptyString()
        {
            string text = " 12345 ";

            Assert.IsFalse(text.IsNullOrEmptyString());
        }
        [TestMethod]
        public void Value()
        {
            string text = " 12345 ";
            
            Assert.AreEqual(5, text.Value().Length);
            Assert.AreEqual("12345", text.Value());
        }
        [TestMethod]
        public void LengthValidade_NotAllowNull()
        {
            string text = " 12345  ";
            Assert.IsTrue(text.LengthValid(false, 1, 5));
        }
        [TestMethod]
        public void LengthValidade_AllowNull()
        {
            string text = null;

            Assert.IsTrue(text.LengthValid(true, 1, 5));
        }
    }
}
