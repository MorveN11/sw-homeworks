using System.Text.RegularExpressions;
using MathLibraryTransfWith;
using MathLibraryTransfWithout;

namespace LibraryTransfExp


{
    public class ExpressionTransf
    {        
        public static string Transform(string _input, bool operatorPrecedence, string operatorPosition)
        {
            if (operatorPrecedence)
            {
                string input = RemoveParentheses(_input);
                string operators = WithPrecedenceExpTransf.Evaluate(input).Item1;
                string numbers = WithPrecedenceExpTransf.Evaluate(input).Item2;
                if (operatorPosition.Equals("Prefix")) {
                    return "{" + operators + "}{" + numbers + "}";
                } else {
                    return "{" + numbers + "}{" + operators + "}";
                }
            }
            else
            {
                string input = RemoveParentheses(_input);
                string operators = WithoutPrecedenceExpTransf.Evaluate(input).Item1;
                string numbers = WithoutPrecedenceExpTransf.Evaluate(input).Item2;
                if (operatorPosition.Equals("Prefix")) {
                    return "{" + operators + "}{" + numbers + "}";
                } else {
                    return "{" + numbers + "}{" + operators + "}";
                }
            }
        }

        public static string RemoveParentheses(string expression)
        {
            string pattern = @"\(([^()]+)\)";
            string result = Regex.Replace(expression, pattern, "$1");
            return result;
        }
    }
}
