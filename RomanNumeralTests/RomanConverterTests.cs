using RomanNumeral;
using Xunit;

namespace RomanNumeralTests
{
    public class RomanConverterTests
    {
        [Fact]
        public void GivenConvert_WhenInputIsZero_ThenReturnEmptyString()
        {
            RomanConverter converter = new RomanConverter();
            int input = 0;
            string expected = "";

            string actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GivenConvert_WhenInputIs1_ThenReturnStringI()
        {
            RomanConverter converter = new RomanConverter();
            int input = 1;
            string expected = "I";

            string actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }
    }
}