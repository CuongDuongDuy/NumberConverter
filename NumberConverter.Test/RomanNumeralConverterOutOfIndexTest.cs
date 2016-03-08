using System;
using Moq;
using NUnit.Framework;

namespace NumberConverter.Test
{
    [TestFixture]
    public class RomanNumeralConverterOutOfIndexTest
    {
        public Mock<RomanNumeralConverter> RomanNumeralConverterMock;

        [SetUp]
        public void Initialize()
        {
            RomanNumeralConverterMock = new Mock<RomanNumeralConverter>();
            RomanNumeralConverterMock.Setup(m => m.ConvertToLetter(It.IsAny<int>())).Returns("10");
        }

        //Just try to apply Mock
        [Test]
        public void MockApply()
        {
            var result = RomanNumeralConverterMock.Object.ConvertToLetter(1);
            Assert.AreEqual("I", result);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberGreaterThan3000ThrowsIndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertToLetter(3001);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberLessThan1ThrowsIndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertToLetter(0);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberMinus1ThrowsIndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertToLetter(-1);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number3002ThrowsIndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertToLetter(3002);
        }
    }

   
}
