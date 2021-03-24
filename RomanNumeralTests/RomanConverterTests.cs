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
        [InlineData(1000, "M")]
        public void Convert_WhenGivenInt_ReturnsNumeralAsString(int input, string expected)
        {
            RomanConverter converter = new RomanConverter();

            string actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4000, 4)]
        [InlineData(4846, 4)]
        [InlineData(846, 1)]
        [InlineData(398, 3)]
        [InlineData(76, 1)]
        [InlineData(44, 4)]
        [InlineData(7, 7)]
        public void SplitNumeralValues_WhenGivenInt_ReturnsNumberOfNumeralOccurrences(int input, int expected)
        {
            RomanConverter converter = new RomanConverter();

            int actual = converter.SplitNumeralValues(input);

            Assert.Equal(expected, actual);
        }
    }
}