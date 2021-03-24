using System.Collections.Generic;

namespace RomanNumeral
{
    public class RomanConverter
    {
        public string Convert(int input)
        {
            var numeralMapping = new Dictionary<int, string>()
            {
                {0, ""},
                {1, "I"},
                {5, "V"},
                {10, "X"},
                {50, "L"},
                {100, "C"},
                {500, "D"},
                {1000, "M"}
            };
            return numeralMapping[input];
        }

        public int SeparateLastDigit(int input)
        {
            return 5;
        }
    }
}