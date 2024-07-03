using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes;

public class Division : IOperation, IBinaryOperation
{
    private double _operand1;
    private double _operand2;
    private readonly IList<double> _operands;

    public Division()
    {
        _operand1 = 0;
        _operand2 = 1;
        _operands = new List<double> {_operand1, _operand2};
    }
    
    public double ExecuteOperation()
    {
        if (_operand2 == 0) throw new DivideByZeroException("Division by zero is not allowed.");
        var result = _operand1 / _operand2;
        return result;
    }

    public IList<double> GetOperands()
    {
        return _operands;
    }

    public void SetOperands(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;

        _operands[0] = _operand1;
        _operands[1] = _operand2;
    }
}