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
        public void Convert_WhenGivenInt_ReturnsNumeralAsString(int input, string expected)
        {
            RomanConverter converter = new RomanConverter();

            string actual = converter.Convert(input);

            Assert.Equal(expected, actual);
        }
        
        // [Fact]
        // public void GivenConvert_WhenInputIsZero_ThenReturnEmptyString()
        // {
        //     RomanConverter converter = new RomanConverter();
        //     int input = 0;
        //     string expected = "";
        //
        //     string actual = converter.Convert(input);
        //
        //     Assert.Equal(expected, actual);
        // }
        //
        // [Fact]
        // public void GivenConvert_WhenInputIs1_ThenReturnStringI()
        // {
        //     RomanConverter converter = new RomanConverter();
        //     int input = 1;
        //     string expected = "I";
        //
        //     string actual = converter.Convert(input);
        //
        //     Assert.Equal(expected, actual);
        // }
        //
        // [Fact]
        // public void Convert_WhenInputIs5_ThenReturnStringV()
        // {
        //     RomanConverter converter = new RomanConverter();
        //     int input = 5;
        //     string expected = "V";
        //
        //     string actual = converter.Convert(input);
        //
        //     Assert.Equal(expected, actual);
        // }
    }
}