using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_7;

namespace lab_7_test
{
    [TestClass]
    public class Lab_test_1
    {
        [TestMethod]
        public void lab_7_test()
        {
            int N = 15;
            zad_1 a = new zad_1();
            string actual = a.Print(N);
            string expected = "ABCDEFGHIJKLMNO";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void lab_7_InvalidTest()
        {
            int N = 27;
            zad_1 a = new zad_1();
            Assert.ThrowsException<ArgumentException>(() => a.Print(N), "не обработан запрос вне диапазона");
        }
    }
}
