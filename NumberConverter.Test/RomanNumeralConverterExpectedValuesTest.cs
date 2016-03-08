using NUnit.Framework;

namespace NumberConverter.Test
{
    [TestFixture]
    public class RomanNumeralConverterExpectedValuesTest
    {
        [Test]
        public void Number_3000_Shoud_Return_MMM()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.ConvertToLetter(3000);
            Assert.AreEqual("MMM", letter);
        }

        [Test]
        public void Number_1000_Should_Return_M()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.ConvertToLetter(1000);
            Assert.AreEqual("M", letter);
        }


        [Test]
        public void Number_550_Should_Return_DL()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.ConvertToLetter(550);
            Assert.AreEqual("DL", letter);
        }

        [Test]
        public void Number_200_Should_Return_CC()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.ConvertToLetter(200);
            Assert.AreEqual("CC", letter);
        }

        [Test]
        public void Number_10_Should_Return_X()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.ConvertToLetter(10);
            Assert.AreEqual("X", letter);
        }

        [Test]
        public void Number_1_Should_Return_I()
        {
            var converter = new RomanNumeralConverter();
            var letter = converter.ConvertToLetter(1);
            Assert.AreEqual("I", letter);
        }

    }
}
