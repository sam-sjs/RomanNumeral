using RomanNumeral;
using Xunit;
using Xunit.Sdk;

namespace RomanNumeralTests
{
    public class RomanConverterTests
    {
        [Fact]
        public void Convert_WhenGiven0_ReturnsEmptyString()
        {
            RomanConverter converter = new RomanConverter();
            int input = 0;
            string expected = "";

            string actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CountNumeral_WhenGivenNumeralAndRemainingValue_ReturnsNumeralCount()
        {
            RomanConverter converter = new RomanConverter();
            string numeral = "M";
            int remainingValue = 4935;
            int expected = 4;

            int actual = converter.CountNumeral(numeral, remainingValue);

            Assert.Equal(expected, actual);
        }
    }   
}