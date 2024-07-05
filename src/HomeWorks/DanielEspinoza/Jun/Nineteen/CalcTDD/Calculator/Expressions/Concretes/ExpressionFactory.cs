using Calculator.Expressions;

namespace Calculator.Tests.Parsing;


public class ExpressionFactory
{
    public static IExpression CreateExpression(IExpression left, string op, IExpression right)
    {
        return op switch
        {
            "+" => new Addition(left, right),
            "-" => new Subtraction(left, right),
            "*" => new Multiplication(left, right),
            "/" => new Division(left, right),
            "^" => new Exponentiation(left, right),
            "%" => new Mod(left, right),
            _ => new Number(0)
        };
    }

}
