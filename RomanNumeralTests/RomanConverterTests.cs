using System;
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
        [InlineData("C", 342, 3)]
        [InlineData("L", 82, 1)]
        [InlineData("X", 39, 3)]
        [InlineData("V", 8, 1)]
        [InlineData("I", 3, 3)]
        public void CountNumeral_GivenNumeralAndRemainingValue_ReturnsNumeralCount(string numeral, int remainingValue, int expected)
        {
            RomanConverter converter = new RomanConverter();

            int actual = converter.CountNumeral(numeral, remainingValue);

            Assert.Equal(expected, actual);
        }

        // [Fact]
        // public void ReduceValue_GivenRemainingValue_ReducesByProcessedAmount()
        // {
        //     
        // }

        [Fact]
        public void GetValue_GivenStringNumeral_ReturnsNumeralValue()
        {
            RomanConverter converter = new RomanConverter();
            string input = "M";
            int expected = 1000;

            int actual = converter.GetValue(input);

            Assert.Equal(expected, actual);
        }
    }   
}