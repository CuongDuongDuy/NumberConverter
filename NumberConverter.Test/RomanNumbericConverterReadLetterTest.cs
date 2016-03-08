using System;
using NUnit.Framework;

namespace NumberConverter.Test
{
    [TestFixture]
    public class RomanNumbericConverterReadLetterTest
    {
        [TestCase("M",Result = 1000)]
        [TestCase("D", Result = 500)]
        [TestCase("C", Result = 100)]
        [TestCase("L", Result = 50)]
        [TestCase("X", Result = 10)]
        [TestCase("V", Result = 5)]
        [TestCase("I", Result = 1)]
        public int ConvertToValueShouldRetureValue(string letter)
        {
            var converter = new RomanNumeralConverter();
            var value = converter.ConvertToValue(letter);
            return value;
        }

        [TestCase("T")]
        [TestCase("G")]
        [TestCase(" ")]
        [ExpectedException(typeof (IndexOutOfRangeException))]
        public void ResultShouldThrowException(string letter)
        {
            var converter = new RomanNumeralConverter();
            converter.ConvertToValue(letter);
        }
    }
}
