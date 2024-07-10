using Calculator.Operations.Concretes;
using Calculator.Operations.Interfaces;
using Calculator.Utils;

namespace Calculator;

public class Calculator : ICalculator
{
    private readonly Dictionary<Operation, IOperation> _operations;
    private readonly ExpressionEvaluator _expressionEvaluator;
    private readonly ExpressionProcessing _expressionProcessing;
    
    public Calculator()
    {
        _operations = new Dictionary<Operation, IOperation>();
        _expressionEvaluator = new ExpressionEvaluator();
        _expressionProcessing = new ExpressionProcessing();
        
        _operations.Add(Operation.Add, new Addition());
        _operations.Add(Operation.Subtraction, new Subtraction());
        _operations.Add(Operation.Multiplication, new Multiplication());
        _operations.Add(Operation.Division, new Division());
        _operations.Add(Operation.Square, new Root());
    }

    public void RegisterOperation(Operation op, IOperation operation)
    {
        if (_operations.ContainsKey(op)) return;
        _operations.Add(op, operation);
    }

    public double PerformOperation(Operation operationName, double value1, double value2)
    {
        if (!_operations.TryGetValue(operationName, out var op)) 
            throw new InvalidOperationException("Operation not found.");
        
        op.SetParameters(value1, value2);
        var opExecutor = (IExecutor) op;
        
        return opExecutor.ExecuteOperation();
    }

    public double PerformExpressionCalculation(string expression)
    {
        if (!_expressionEvaluator.IsACorrectOperation(expression)) 
            throw new InvalidOperationException("Invalid Expression.");
        
        var evaluatedExpression = _expressionEvaluator.GetEvaluatedExpression(expression);
        var operators = _expressionProcessing.GetOperatorsFromExpression(evaluatedExpression);
        var operands = _expressionProcessing.GetOperandsFromExpression(evaluatedExpression);
        double result = operands[0];
        
        for (var i = 0; i < operators.Count; i++)
            result = PerformOperation(operators[i], result, operands[i + 1]);
        return result;
    }
}