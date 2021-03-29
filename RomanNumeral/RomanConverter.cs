
using System;
using System.Collections.Generic;

namespace RomanNumeral
{
    public class RomanConverter
    {
        public string Convert(int input)
        {
            int remainingValue = input;
            string completedNumeral = "";
            char[] numerals = {'M', 'D', 'C', 'L', 'X', 'V', 'I'};
            foreach (char numeral in numerals)
            {
                completedNumeral += ProcessNumeral(numeral, remainingValue);
                remainingValue -= CountNumeral(numeral, remainingValue) * GetNumeralValue(numeral);
            }

            return completedNumeral;
        }

        public int CountNumeral(char numeral, int remainingValue)
        {
            return (int)Math.Floor((double)remainingValue / GetNumeralValue(numeral));
        }

        public int GetNumeralValue(char numeral)
        {
            Dictionary<char, int> numeralValue = new Dictionary<char, int>
            {
                {'M', 1000},
                {'D', 500},
                {'C', 100},
                {'L', 50},
                {'X', 10},
                {'V', 5},
                {'I', 1}
            };
            return numeralValue[numeral];
        }

        public string ProcessNumeral(char numeral, int remainingValue)
        {
            int currentNumeralCount = CountNumeral(numeral, remainingValue);
            return new string(numeral, currentNumeralCount);
        }
    }
}