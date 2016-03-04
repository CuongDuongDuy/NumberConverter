using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NumberConverter.Test
{
    [TestClass]
    public class RomanNumeralConverterOutOfIndexTest
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberGreaterThan3000ThrowsIndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.CovertToLetter(3001);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberLessThan1ThrowsIndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.CovertToLetter(0);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberMinus1ThrowsIndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.CovertToLetter(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Number3002ThrowsIndexOutOfRangeException()
        {
            var converter = new RomanNumeralConverter();
            converter.CovertToLetter(3002);
        }
    }

   
}
