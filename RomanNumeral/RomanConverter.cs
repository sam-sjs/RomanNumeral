
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
            if (numeral == "D") return remainingValue / 500;
            if (numeral == "M") return remainingValue / 1000;
            return 0;
        }
    }
}