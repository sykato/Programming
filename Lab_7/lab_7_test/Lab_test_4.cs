using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using lab_7;

namespace lab_7_test
{
    [TestClass]
    public class Lab_test_4
    {
        [TestMethod]
        public void MailTest()
        {
            bool actual = new zad_4().Mail("hello@world.ru");
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void InvalidMailTest1()
        {
            zad_4 actual = new zad_4();
            Assert.IsFalse(actual.Mail("absssssssssssss"));
        }
        [TestMethod]
        public void InvalidMailTest2()
        {
            zad_4 actual = new zad_4();
            Assert.ThrowsException<ArgumentNullException>(() => actual.Mail(null), "пустая строка");

            Assert.IsFalse(actual.Mail(String.Empty));
        }

    }
}
