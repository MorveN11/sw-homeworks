using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes;

public class SquareRoot : IOperation, IUnaryOperation
{
    private double _operand;
    private readonly IList<double> _operands;

    public SquareRoot()
    {
        _operand = 0;
        _operands = new List<double> {_operand};
    }

    public double ExecuteOperation()
    {
        if (_operand < 0) throw new ArgumentException("Cannot take square root of a negative number");
        var result = Math.Sqrt(_operand);
        return result;
    }

    public IList<double> GetOperands()
    {
        return _operands;
    }

    public void SetOperand(double operand)
    {
        _operand = operand;
        
        _operands[0] = operand;
    }
}