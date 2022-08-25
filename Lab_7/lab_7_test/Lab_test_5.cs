using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_7;

namespace lab_7_test
{
    [TestClass]
    public class Lab_test_5
    {
        [TestMethod]
        public void SumNumbersTest()
        {
            int actual = new zad_5().Summ(" 123");
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void SumNumbersInvalidTest1()
        {
            Assert.ThrowsException<Exception>(() => new zad_5().Summ("аываыва123"), "В строке находятся не только цифры");
        }
        [TestMethod]
        public void SumNumbersInvalidTest2()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Fifth().Summ(""), "Строка пустая");
        }

    }
}
