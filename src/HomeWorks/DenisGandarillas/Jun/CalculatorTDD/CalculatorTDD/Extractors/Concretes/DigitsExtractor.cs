using System.Text.RegularExpressions;

namespace CalculatorTDD
{
    public class DigitsExtractor : IExtractor
    {
        private readonly Converter _converter;

        public DigitsExtractor()
        {
            _converter = new Converter();
        }

        public string Extract(string operation)
        {
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(operation);

            return _converter.convertListToString(matches);
        }
    }
}
