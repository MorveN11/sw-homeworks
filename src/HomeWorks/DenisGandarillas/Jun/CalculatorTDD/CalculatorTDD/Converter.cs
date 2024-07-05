using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorTDD
{
    public class Converter
    {

        public string OperationConverter(string operation)
        {
            return $"{GetOperators(operation)}|{GetDigits(operation)}";
        }

        public string GetOperators(string operation)
        {
            string pattern = @"[+\-*/]";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(operation);

            return convertListToString(matches);
        }

        public string GetDigits(string operation)
        {
            string pattern = @"\d+";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(operation);

            return convertListToString(matches);
        }

        private string convertListToString(MatchCollection matches)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < matches.Count; i++)
            {
                result.Append(matches[i].Value);
                if (i < matches.Count - 1)
                {
                    result.Append(",");
                }
            }

            return result.ToString();
        }
    }
}
