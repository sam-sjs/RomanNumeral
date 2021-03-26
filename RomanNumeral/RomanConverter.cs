
using System;
using System.Collections.Generic;

namespace RomanNumeral
{
    public class RomanConverter
    {
        public string Convert(int input)
        {
            int remainingInput = input;
            if (input == 0) return "";
            string completedNumeral = "";
            char[] numerals = {'M', 'D', 'C', 'L', 'X', 'V', 'I'};
            foreach (char numeral in numerals)
            {
                int currentNumeralCount = CountNumeral(numeral, remainingInput);
                completedNumeral += new string(numeral, currentNumeralCount);
                remainingInput -= currentNumeralCount * GetValue(numeral);
            }

            return completedNumeral;
        }

        public int CountNumeral(char numeral, int remainingValue)
        {
            return remainingValue / GetValue(numeral);
        }

        public int GetValue(char numeral)
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
    }
}