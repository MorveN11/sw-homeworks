using Calculator.Operations.Concretes;
using Calculator.Operations.Interfaces;
using Calculator.Utils;

namespace Calculator;

public class Calculator : ICalculator
{
    private readonly Dictionary<Operation, IMoreThanOneOperandOperation> _operations;
    private readonly Dictionary<Operation, ISingleOperandOperation> _singleOperandOperations;

    public Calculator()
    {
        _operations = new Dictionary<Operation, IMoreThanOneOperandOperation>();
        _singleOperandOperations = new Dictionary<Operation, ISingleOperandOperation>();
        
        _operations.Add(Operation.Add, new Addition());
        _operations.Add(Operation.Subtraction, new Subtraction());
        _operations.Add(Operation.Multiplication, new Multiplication());
        _operations.Add(Operation.Division, new Division());
        _operations.Add(Operation.Pow, new Pow());
        
        _singleOperandOperations.Add(Operation.SquareRoot, new SquareRoot());
    }
    
    public void RegisterOperation(Operation operation, IOperation iOperation)
    {
        if (_singleOperandOperations.ContainsKey(operation) && _operations.ContainsKey(operation)) return;
        switch (iOperation)
        {
            case ISingleOperandOperation singleOperation:
                _singleOperandOperations.Add(operation, singleOperation);
                break;
            case IMoreThanOneOperandOperation operandOperation:
                _operations.Add(operation, operandOperation);
                break;
        }

    }

    public double PerformOperation(Operation op, double value1, double value2, params double[] numbers)
    {
        if (!_operations.TryGetValue(op, out var operation))
            throw new InvalidOperationException("Operation not found.");

        var result = operation.Operate(value1, value2, numbers);
        return result;
    }

    public double PerformOperation(Operation op, double value)
    {
        if (!_singleOperandOperations.TryGetValue(op, out var operation))
            throw new InvalidOperationException("Operation not found.");

        var result = operation.Operate(value);
        return result;
    }
}