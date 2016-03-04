using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberConverter.Test
{
    [TestClass]
    public class RomanNumeralConverterExpectedValuesTest
    {
        [TestMethod]
        public void Number_3000_Shoud_Return_MMM()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.CovertToLetter(3000);
            Assert.AreEqual("MMM", letter);
        }

        [TestMethod]
        public void Number_1000_Should_Return_M()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.CovertToLetter(1000);
            Assert.AreEqual("M", letter);
        }


        [TestMethod]
        public void Number_550_Should_Return_DL()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.CovertToLetter(550);
            Assert.AreEqual("DL", letter);
        }

        [TestMethod]
        public void Number_200_Should_Return_CC()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.CovertToLetter(200);
            Assert.AreEqual("CC", letter);
        }

        [TestMethod]
        public void Number_10_Should_Return_X()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.CovertToLetter(10);
            Assert.AreEqual("X", letter);
        }

        [TestMethod]
        public void Number_1_Should_Return_I()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.CovertToLetter(1);
            Assert.AreEqual("I", letter);
        }

    }
}
