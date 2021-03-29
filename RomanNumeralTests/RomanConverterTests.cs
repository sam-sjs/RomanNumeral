using RomanNumeral;
using Xunit;

namespace RomanNumeralTests
{
    public class RomanConverterTests
    {
        [Theory]
        [InlineData(0, "")]
        [InlineData(4000, "MMMM")]
        [InlineData(300, "CCC")]
        [InlineData(2100, "MMC")]
        public void Convert_WhenGiven0_ReturnsEmptyString(int input, string expected)
        {
            RomanConverter converter = new RomanConverter();

            string actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('M', 4935, 4)]
        [InlineData('D', 876, 1)]
        [InlineData('C', 342, 3)]
        [InlineData('L', 82, 1)]
        [InlineData('X', 39, 3)]
        [InlineData('V', 8, 1)]
        [InlineData('I', 3, 3)]
        public void CountNumeral_GivenNumeralAndRemainingValue_ReturnsNumeralCount(char numeral, int remainingValue, int expected)
        {
            RomanConverter converter = new RomanConverter();

            int actual = converter.CountNumeral(numeral, remainingValue);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('M', 1000)]
        [InlineData('D', 500)]
        [InlineData('C', 100)]
        [InlineData('L', 50)]
        [InlineData('X', 10)]
        [InlineData('V', 5)]
        [InlineData('I', 1)]
        public void GetNumeralValue_GivenNumeralAsChar_ReturnsValueAsInt(char numeral, int expected)
        {
            RomanConverter converter = new RomanConverter();

            int actual = converter.GetNumeralValue(numeral);

            Assert.Equal(expected, actual);
        }
    }   
}