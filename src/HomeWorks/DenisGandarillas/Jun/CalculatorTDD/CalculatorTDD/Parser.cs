using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorTDD
{
    public class Parser
    {
        private readonly IExtractor _operatorExtractor;
        private readonly IExtractor _digitsExtractor;

        public Parser()
        {
            _operatorExtractor = new OperatorExtractor();
            _digitsExtractor = new DigitsExtractor();
        }

        public string Parse(string operation)
        {
            return $"{_operatorExtractor.Extract(operation)}|{_digitsExtractor.Extract(operation)}";
        }
    }
}
