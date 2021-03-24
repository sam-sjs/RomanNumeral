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

        [Theory]
        [InlineData(5, 5)]
        [InlineData(15, 5)]
        [InlineData(3298473, 3)]
        public void SeparateLastDigit_WhenGivenInt_ReturnsLastDigit(int input, int expected)
        {
            RomanConverter converter = new RomanConverter();

            int actual = converter.SeparateLastDigit(input);

            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void SplitNumeralValues_WhenGivenInt_ReturnsNumberOfNumeralOccurrences()
        {
            RomanConverter converter = new RomanConverter();
            int input = 4000;
            int expected = 4;

            int actual = converter.SplitNumeralValues(input);

            Assert.Equal(expected, actual);
        }
    }
}