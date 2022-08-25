using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_7;

namespace lab_7_test
{
    [TestClass]
    public class Lab_test_2
    {
        [TestMethod]
        public void DiscriminantZeroTest()
        {
            zad_2 s = new zad_2();
            double[] arr = new double[1] { -1 };
            double[] actual = new double[1];
            actual = s.Equation(1, 2, 1);
            Assert.AreEqual(arr[0], actual[0], 0.01);
        }
        [TestMethod]
        public void DiscriminantLessZeroTest()
        {
            zad_2 s = new zad_2();
            double[] arr = new double[1] { -1 };
            Assert.ThrowsException<ArgumentException>(() => s.Equation(1, 1, 1), "Дискриминант меньше нуля");
        }
        [TestMethod]
        public void DiscriminantМoreZeroTest()
        {
            zad_2 s = new zad_2();
            double[] arr = new double[2] { -0.20, -4.79 };
            double[] actual = new double[2];
            actual = s.Equation(1, 5, 1);
            Assert.AreEqual(arr[0], actual[0], 0.01);
            Assert.AreEqual(arr[1], actual[1], 0.01);
        }
        [TestMethod]
        public void AZeroTest()
        {
            zad_2 s = new zad_2();
            Assert.ThrowsException<ArgumentException>(() => s.Equation(0, 1, 1), "Уравнение не квадратичное");
        }
    }
}
