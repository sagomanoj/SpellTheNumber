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

        [TestMethod]
        public void CheckTwentyThousand()
        {
            Assert.AreEqual("twenty five thounsand six hundred and twenty five", SpellNumberProvider.Instance.SpellTheNumber(25625));
        }

        [TestMethod]
        public void CheckHunderedThousand()
        {
            Assert.AreEqual("two hundred and fifty six thounsand two hundred and fifty eight", SpellNumberProvider.Instance.SpellTheNumber(256258));
        }

        [TestMethod]
        public void CheckMillion()
        {
            Assert.AreEqual("two million five hundred and sixty two thounsand five hundred and eighty nine", SpellNumberProvider.Instance.SpellTheNumber(2562589));
        }

        [TestMethod]
        public void CheckTwoMillion()
        {
            Assert.AreEqual("two million", SpellNumberProvider.Instance.SpellTheNumber(2000000).Trim());
        }

        [TestMethod]
        public void CheckTenMillion()
        {
            Assert.AreEqual("twenty million", SpellNumberProvider.Instance.SpellTheNumber(20000000).Trim());
        }

        [TestMethod]
        public void CheckHunderedMillion()
        {
            Assert.AreEqual("two hundred  million", SpellNumberProvider.Instance.SpellTheNumber(200000000).Trim());
        }

        [TestMethod]
        public void CheckBillion()
        {
            Assert.AreEqual("two billion", SpellNumberProvider.Instance.SpellTheNumber(2000000000).Trim());
        }

        [TestMethod]
        public void CheckTwentyBillion()
        {
            Assert.AreEqual("twenty billion", SpellNumberProvider.Instance.SpellTheNumber(20000000000).Trim());
        }

        [TestMethod]
        public void CheckTwoHundredBillion()
        {
            Assert.AreEqual("two hundred  billion", SpellNumberProvider.Instance.SpellTheNumber(200000000000).Trim());
        }

        [TestMethod]
        public void CheckTwoTrillion()
        {
            Assert.AreEqual("two trillion", SpellNumberProvider.Instance.SpellTheNumber(2000000000000).Trim());
        }
    }
}
