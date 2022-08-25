using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_7;

namespace lab_7_test
{
    [TestClass]
    public class Lab_test_3
    {
        [TestMethod]
        public void YearTest()
        {
            Assert.AreEqual(DateTime.IsLeapYear(2022), zad_3.Year(2022) == 366);
            Assert.AreEqual(DateTime.IsLeapYear(2020), zad_3.Year(2020) == 366);
            Assert.AreEqual(DateTime.IsLeapYear(300), zad_3.Year(300) == 366);
            Assert.AreEqual(DateTime.IsLeapYear(1200), zad_3.Year(1200) == 366);
            Assert.AreEqual(DateTime.IsLeapYear(4), zad_3.Year(4) == 366);
        }
        [TestMethod]
        public void Zero()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => zad_3.Year(0), "Отрицательный год");

        }
    }
}
