using RomanNumeral;
using Xunit;

namespace RomanNumeralTests
{
    public class RomanConverterTests
    {
        [Fact]
        public void GivenConvert_WhenInputIsNull_ThenReturnEmptyString()
        {
            RomanConverter converter = new RomanConverter();
            string expected = "";

            string actual = converter.Convert();

            Assert.Equal(expected, actual);
        }
    }
}