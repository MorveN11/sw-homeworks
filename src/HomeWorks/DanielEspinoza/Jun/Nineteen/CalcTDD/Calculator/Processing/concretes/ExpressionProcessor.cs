using Calculator.Expressions;
using Calculator.Parsing;
using Calculator.Exceptions;

namespace Calculator.Processing;

public class ExpressionProcessor : IExpressionProcessor
{

    private readonly IFormatter _formatter;
    private readonly IParser _parser;
    private readonly IValidator _validator;

    public ExpressionProcessor(IFormatter formatter, IParser parser, IValidator validator)
    {
        _formatter = formatter;
        _parser = parser;
        _validator = validator;
    }

    public double ProcessExpression(string expression)
    {
         if (!_validator.Validate(expression))
        {
            throw new InvalidExpressionException();
        }

        string formattedExpression = _formatter.Format(expression);
        IExpression expressionTree = _parser.Parse(formattedExpression);
        double result  = expressionTree.Evaluate();

        return Math.Round(result,2);
    }
}
