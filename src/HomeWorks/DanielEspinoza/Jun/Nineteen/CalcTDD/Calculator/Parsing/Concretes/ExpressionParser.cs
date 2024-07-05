using Calculator.Expressions;
using Calculator.Tests.Parsing;

namespace Calculator.Parsing;


public class ExpressionParser : IParser
{
    public IExpression Parse(string expression)
    {
        string[] expressions = expression.Split('&');

        string[] numbers = expressions[1].Split(',');
        string operators = expressions[0];
        double number = double.Parse(numbers[0]);

        IExpression leftExpression = new Number(number);

        for (int i = 1; i <= operators.Length; i++)
        {
            leftExpression = ExpressionFactory.CreateExpression(leftExpression, operators[i-1].ToString(), new Number(double.Parse(numbers[i])));

        }

        return leftExpression;
    }
}
