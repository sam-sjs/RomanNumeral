
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
                {"L", 50}
            };
            return remainingValue / numeralValue[numeral];
        }
    }
}