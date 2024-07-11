using System.Text.RegularExpressions;

namespace MathLibraryTransfWithout


{
    public static class WithoutPrecedenceExpTransf
    {        
        public static (string,string) Evaluate(string input)
        {
            string operatorsPattern = @"[+\-*/^]";
            string numbersPattern = @"\d+";

            List<string> operators = new List<string>();
            List<string> numbers = new List<string>();

            foreach (Match match in Regex.Matches(input, operatorsPattern))
            {
                operators.Add(match.Value);
            }

            foreach (Match match in Regex.Matches(input, numbersPattern))
            {
                numbers.Add(match.Value);
            }

            string listOperators = string.Join("", operators);
            string listnumbers = string.Join(",", numbers);

            return (listOperators, listnumbers);
        }
    }
}
