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
                {5, "V"}
            };
            return numeralMapping[input];
        }
    }
}