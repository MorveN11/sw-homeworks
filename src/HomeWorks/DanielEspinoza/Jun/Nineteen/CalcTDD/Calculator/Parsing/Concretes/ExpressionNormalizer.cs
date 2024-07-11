using System.Text.RegularExpressions;

namespace Calculator.Parsing;

public class ExpressionNormalizer : INormalizer
{
    public string Normalize(string expression)
    {
        string normalized = NormalizeSubtractions(expression.Replace(" ", ""));

        normalized = normalized.Replace("--", "+")
                               .Replace("-+", "+-")
                               .Replace("++", "+")
                               .Replace("/+-", "/-")
                               .Replace("*+-", "*-")
                               .Replace("%+-", "%-")
                               .Replace("^+-", "^-");
        return normalized;
    }


    private string NormalizeSubtractions(string expression)
    {
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
}
