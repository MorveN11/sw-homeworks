using System.Text.RegularExpressions;

namespace Calculator.Parsing;

public class ExpressionValidator : IValidator
{
    public bool Validate(string expression)
    {
        string validatedExpression = expression
                                .Replace("++","+")
                                .Replace("--","-")
                                .Replace("+-","-")
                                .Replace("-+","+");
        string pattern = @"^\s*-?\d+(\s*[-+*/^%]\s*-?\d+)*\s*$";
        Regex regex = new(pattern);
        return regex.IsMatch(validatedExpression);
    }
}
