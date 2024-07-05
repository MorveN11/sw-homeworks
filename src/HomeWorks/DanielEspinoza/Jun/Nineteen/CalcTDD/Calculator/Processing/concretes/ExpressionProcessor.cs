using Calculator.Expressions;
using Calculator.Parsing;

namespace Calculator.Processing;

public class ExpressionProcessor : IExpressionProcessor
{

    private readonly IFormatter _formatter;
    private readonly IParser _parser;

    public ExpressionProcessor(IFormatter formatter, IParser parser)
    {
        _formatter = formatter;
        _parser = parser;
    }

    public double ProcessExpression(string expression)
    {
        string formattedExpression = _formatter.Format(expression);
        IExpression expressionTree = _parser.Parse(formattedExpression);
        return expressionTree.Evaluate();
    }
}
