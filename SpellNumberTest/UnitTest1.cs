using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpellTheNumbers;

namespace SpellNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckZero()
        {
            Assert.AreEqual("zero", SpellNumberProvider.Instance.SpellTheNumber(0));
        }

        [TestMethod]
        public void CheckSingleDigit()
        {
            Assert.AreEqual("one", SpellNumberProvider.Instance.SpellTheNumber(1));
        }

        [TestMethod]
        public void CheckTwoDigits()
        {
            Assert.AreEqual("twelve", SpellNumberProvider.Instance.SpellTheNumber(12));
        }

        [TestMethod]
        public void CheckTwenty()
        {
            Assert.AreEqual("twenty", SpellNumberProvider.Instance.SpellTheNumber(20));
        }

        [TestMethod]
        public void CheckTens()
        {
            Assert.AreEqual("thirty", SpellNumberProvider.Instance.SpellTheNumber(30));
        }

        [TestMethod]
        public void CheckHundred()
        {
            Assert.AreEqual("one hundred", SpellNumberProvider.Instance.SpellTheNumber(100).Trim());
        }

        [TestMethod]
        public void CheckMultipleHunderd()
        {
            Assert.AreEqual("two hundred", SpellNumberProvider.Instance.SpellTheNumber(200).Trim());
        }


        [TestMethod]
        public void CheckHunderedAndNumber()
        {
            Assert.AreEqual("one hundred and twenty three", SpellNumberProvider.Instance.SpellTheNumber(123));
        }
    }
}
