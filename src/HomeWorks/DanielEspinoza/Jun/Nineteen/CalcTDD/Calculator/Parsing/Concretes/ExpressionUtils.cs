
using System.Collections.Immutable;
using System.Net;
using System.Text.RegularExpressions;

namespace Calculator.Parsing;


public class ExpressionUtils
{

    public static Dictionary<char, int> Precedence = new Dictionary<char, int>{
        {'+', 1},
        {'-', 1},
        {'*', 2},
        {'/', 2},
        {'^', 3},
        {'%', 3}
    };


    public static string[] GetOperators()
    {
        return ["^","%", "/", "*", "+"];
    }

    public static int GetPrecedence(char c)
    {
        if (Precedence.ContainsKey(c))
        {
            return Precedence[c];
        }
        else
        {
            throw new InvalidOperatorException($"Invalid operator: {c}");
        }
    }


    public static bool IsOperator(char c)
    {
        return c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '%';
    }

    public static bool IsValidExpression(string expression)
    {
        string pattern = @"^\s*-?\d+(\s*[-+*/]\s*-?\d+)*\s*$";
        Regex regex = new(pattern);
        return regex.IsMatch(expression);
    }

    public static string NormalizeExpression(string expression)
    {
        string normalized = NormalizeSubstractions(expression.Replace(" ", ""));

        normalized = normalized.Replace("--", "+")
                               .Replace("-+", "+-")
                               .Replace("++", "+")
                               .Replace("/+-", "/-")
                               .Replace("*+-", "*-")
                               .Replace("%+-", "%-")
                               .Replace("^+-", "^-");
        return normalized;
    }

    public static string NormalizeSubstractions(string expression){
        string pattern = @"(\d+)-(\d+)";

        string replacement = "$1+-$2";

        string result;
        do
        {
            result = expression;
            expression = Regex.Replace(expression, pattern, replacement);
        } while (result != expression);

        return expression;
    }



    public static string[] ExtractOperators(string expression)
    {
        string pattern = @"([\+\*/%\^])";

        Regex regex = new(pattern);

        MatchCollection matches = regex.Matches(expression);
        string[] operators = new string[matches.Count];
        int index = 0;
        foreach (Match match in matches)
        {
            operators[index++] = match.Value;
        }

        return operators;
    }

    public static string[] ExtractNumbers(string expression)
    {
        string pattern = @"(-?\d+)";
        Regex regex = new(pattern);

        MatchCollection matches = regex.Matches(expression);
        string[] numbers = new string[matches.Count];
        int index = 0;
        foreach (Match match in matches)
        {
            numbers[index++] = match.Groups[1].Value;
        }

        return numbers;
    }

}

[Serializable]
internal class InvalidOperatorException : Exception
{
    public InvalidOperatorException()
    {
    }

    public InvalidOperatorException(string? message) : base(message)
    {
    }

    public InvalidOperatorException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
