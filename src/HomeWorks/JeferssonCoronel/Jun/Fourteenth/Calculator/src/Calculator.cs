using Calculator.Operations.Concretes;
using Calculator.Operations.Interfaces;
using Calculator.Utils;

namespace Calculator;

public class Calculator : ICalculator
{
    private readonly Dictionary<Operation, IBinaryOperation> _binaryOperations;
    private readonly Dictionary<Operation, IUnaryOperation> _unaryOperations;
    private readonly ExpressionEvaluator _expressionEvaluator;
    private readonly ExpressionProcessing _expressionProcessing;
    
    public Calculator()
    {
        _binaryOperations = new Dictionary<Operation, IBinaryOperation>();
        _unaryOperations = new Dictionary<Operation, IUnaryOperation>();
        _expressionEvaluator = new ExpressionEvaluator();
        _expressionProcessing = new ExpressionProcessing();
        
        _binaryOperations.Add(Operation.Add, new Addition());
        _binaryOperations.Add(Operation.Subtraction, new Subtraction());
        _binaryOperations.Add(Operation.Multiplication, new Multiplication());
        _binaryOperations.Add(Operation.Division, new Division());
        _binaryOperations.Add(Operation.Pow, new Pow());

        _unaryOperations.Add(Operation.SquareRoot, new SquareRoot());
    }

    public void RegisterOperation(Operation op, IBinaryOperation operation)
    {
        if (_binaryOperations.ContainsKey(op)) return;
        _binaryOperations.Add(op, operation);
    }

    public void RegisterOperation(Operation op, IUnaryOperation operation)
    {
        if (_unaryOperations.ContainsKey(op)) return;
        _unaryOperations.Add(op, operation);
    }

    public double PerformOperation(Operation operationName, double value1, double value2)
    {
        if (!_binaryOperations.TryGetValue(operationName, out var op))
            throw new InvalidOperationException("Operation not found.");

        op.SetOperands(value1, value2);
        var operation = (IOperation)op;

        return operation.ExecuteOperation();
    }

    public double PerformOperation(Operation operationName, double value)
    {
        if (!_unaryOperations.TryGetValue(operationName, out var op))
            throw new InvalidOperationException("Operation not found.");

        op.SetOperand(value);
        var operation = (IOperation)op;

        return operation.ExecuteOperation();
    }

    public double PerformExpressionCalculation(string expression)
    {
        if (!_expressionEvaluator.IsACorrectOperation(expression)) return 0;

        var evaluatedExpression = _expressionEvaluator.GetEvaluatedExpression(expression);
        var (operators, operands) = _expressionProcessing.GetOperationsDividedInOperatorsAndOperands(
            evaluatedExpression);

        double result = operands[0];

        for (var i = 0; i < operators.Count; i++)
        {
            if (i + 1 >= operands.Count) throw new InvalidOperationException("Mismatch between operators and operands.");
            result = PerformOperation(operators[i], result, operands[i + 1]);
        } return result;
    }
}