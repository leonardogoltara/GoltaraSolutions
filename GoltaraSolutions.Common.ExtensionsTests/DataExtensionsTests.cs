using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoltaraSolutions.Common.Extensions.Tests
{
    [TestClass]
    public class DataExtensionsTests
    {
        [TestMethod]
        public void FirstHourOfDay()
        {
            DateTime d = new DateTime(2016, 09, 10, 20, 15, 10);
            d = d.FirstHourOfDay();

            Assert.AreEqual(d.Hour, 0);
            Assert.AreEqual(d.Minute, 0);
            Assert.AreEqual(d.Second, 0);
            Assert.AreEqual(d.Millisecond, 0);
        }
        [TestMethod]
        public void FirstDayOfMonth()
        {
            DateTime d = new DateTime(2016, 09, 10, 20, 15, 10);
            d = d.FirstDayOfMonth();

            Assert.AreEqual(d.Day, 1);
        }
        [TestMethod]
        public void LastHourOfDay()
        {
            DateTime d = new DateTime(2016, 09, 10, 20, 15, 10);
            d = d.LastHourOfDay();

            Assert.AreEqual(d.Hour, 23);
            Assert.AreEqual(d.Minute, 59);
            Assert.AreEqual(d.Second, 59);
            Assert.AreEqual(d.Millisecond, 997);
        }
        [TestMethod]
        public void LastDayOfMonth()
        {
            DateTime d = new DateTime(2016, 09, 10, 20, 15, 10);
            d = d.LastDayOfMonth();

            Assert.AreEqual(d.Day, 30);
        }
        [TestMethod]
        public void AddWorkingDays()
        {
            DateTime d = new DateTime(2016, 10, 10, 00, 00, 00);
            d = d.AddWorkingDays(5);

            Assert.AreEqual(new DateTime(2016, 10, 15, 00, 00, 00), d);
        }
        [TestMethod]
        public void AddWorkingDaysSaturday()
        {
            DateTime d = new DateTime(2016, 10, 13, 00, 00, 00);
            d = d.AddWorkingDays(5);

            Assert.AreEqual(new DateTime(2016, 10, 20, 00, 00, 00), d);
        }
        [TestMethod]
        public void AddWorkingDaysSunday()
        {
            DateTime d = new DateTime(2016, 10, 15, 00, 00, 00);
            d = d.AddWorkingDays(5);

            Assert.AreEqual(new DateTime(2016, 10, 22, 00, 00, 00), d);
        }
        [TestMethod]
        public void GetWorkingDaysDiff()
        {
            DateTime d = new DateTime(2016, 10, 10, 00, 00, 00);
            DateTime d2 = new DateTime(2016, 10, 17, 00, 00, 00);

            Assert.AreEqual(5, d.GetWorkingDaysDiff(d2));
        }
        [TestMethod]
        public void HasValue()
        {
            DateTime date = new DateTime();

            Assert.IsFalse(date.HasValue());
        }
    }
}
