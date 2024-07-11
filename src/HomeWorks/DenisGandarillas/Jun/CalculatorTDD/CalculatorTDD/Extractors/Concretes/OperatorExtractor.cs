using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace CalculatorTDD
{
    public class OperatorExtractor : IExtractor
    {
        private readonly Converter _converter;

        public OperatorExtractor()
        {
            _converter = new Converter();
        }

        public string Extract(string operation)
        {
            string pattern = @"[+\-*/()]";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(operation);

            return _converter.convertListToString(matches);
        }
    }
}
