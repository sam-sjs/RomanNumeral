using RomanNumeral;
using Xunit;

namespace RomanNumeralTests
{
    public class RomanConverterTests
    {
        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "I")]
        [InlineData(5, "V")]
        [InlineData(10, "X")]
        [InlineData(50, "L")]
        [InlineData(100, "C")]
        [InlineData(500, "D")]
        public void Convert_WhenGivenInt_ReturnsNumeralAsString(int input, string expected)
        {
            RomanConverter converter = new RomanConverter();

            string actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }
    }
}