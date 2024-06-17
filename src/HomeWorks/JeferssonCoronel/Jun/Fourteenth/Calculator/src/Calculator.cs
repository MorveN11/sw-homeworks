using Calculator.Operations.Concretes;
using Calculator.Operations.Interfaces;

namespace Calculator;

public class Calculator : ICalculator
{
    private readonly Dictionary<string, IMoreThanOneOperandOperation> _operations;
    private readonly Dictionary<string, ISingleOperandOperation> _singleOperandOperations;

    public Calculator()
    {
        _operations = new Dictionary<string, IMoreThanOneOperandOperation>();
        _singleOperandOperations = new Dictionary<string, ISingleOperandOperation>();
        
        _operations.Add("add", new Addition());
        _operations.Add("subtract", new Subtraction());
        _operations.Add("multiply", new Multiplication());
        _operations.Add("divide", new Division());
        _operations.Add("pow", new Pow());
        
        _singleOperandOperations.Add("square-root", new SquareRoot());
    }
    
    public void RegisterOperation(string name, IOperation operation)
    {
        if (_singleOperandOperations.ContainsKey(name) && _operations.ContainsKey(name)) return;
        switch (operation)
        {
            case ISingleOperandOperation singleOperation:
                _singleOperandOperations.Add(name, singleOperation);
                break;
            case IMoreThanOneOperandOperation operandOperation:
                _operations.Add(name, operandOperation);
                break;
        }

    }

    public double PerformOperation(string name, double value1, double value2, params double[] numbers)
    {
        if (!_operations.TryGetValue(name, out var operation))
            throw new InvalidOperationException("Operation not found.");

        var result = operation.Operate(value1, value2, numbers);
        return result;
    }

    public double PerformOperation(string name, double value)
    {
        if (!_singleOperandOperations.TryGetValue(name, out var operation))
            throw new InvalidOperationException("Operation not found.");

        var result = operation.Operate(value);
        return result;
    }
}