using Calculator.Expressions;
using Calculator.Parser;
namespace Calculator;

public class MathCalculator
{
    public static double Calculate(string input)
    {
        var parser = new ExprParser(input);
        Expr expression = parser.Parse();
        double result = expression.Evaluate();
        return result;
    }
}