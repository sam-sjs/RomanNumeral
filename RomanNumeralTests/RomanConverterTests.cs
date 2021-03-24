using System;
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

        [Fact]
        public void SeparateLastDigit_WhenGivenInt_ReturnsLastDigit()
        {
            RomanConverter converter = new RomanConverter();
            int input = 5;
            int expected = 5;

            int actual = converter.SeparateLastDigit(input);

            Assert.Equal(expected, actual);
        }
    }
}