
using System.Collections.Generic;

namespace RomanNumeral
{
    public class RomanConverter
    {
        public string Convert(int input)
        {
            return "";
        }

        public int CountNumeral(string numeral, int remainingValue)
        {
            Dictionary<string, int> numeralValue = new Dictionary<string, int>
            {
                {"M", 1000},
                {"D", 500},
                {"C", 100},
                {"L", 50},
                {"X", 10},
                {"V", 5},
                {"I", 1}
            };
            return remainingValue / numeralValue[numeral];
        }

        public int GetValue(string numeral)
        {
            Dictionary<string, int> numeralValue = new Dictionary<string, int>
            {
                {"M", 1000},
                {"D", 500},
                {"C", 100},
                {"L", 50},
                {"X", 10},
                {"V", 5},
                {"I", 1}
            };
            return numeralValue[numeral];
        }
    }
}