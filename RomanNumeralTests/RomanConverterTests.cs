using System.Diagnostics;
using RomanNumeral;
using Xunit;

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

        [Theory]
        [InlineData("M", 4935, 4)]
        [InlineData("D", 876, 1)]
        public void CountNumeral_WhenGivenNumeralAndRemainingValue_ReturnsNumeralCount(string numeral, int remainingValue, int expected)
        {
            RomanConverter converter = new RomanConverter();

            int actual = converter.CountNumeral(numeral, remainingValue);

            Assert.Equal(expected, actual);
        }
    }   
}