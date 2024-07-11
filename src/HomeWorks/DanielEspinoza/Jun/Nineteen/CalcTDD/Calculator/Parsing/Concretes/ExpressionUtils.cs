using Calculator.Exceptions;
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

