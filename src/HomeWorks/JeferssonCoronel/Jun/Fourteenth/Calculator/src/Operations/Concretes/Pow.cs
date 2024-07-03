using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes;

public class Pow : IOperation, IBinaryOperation
{
    private double _operand1;
    private double _operand2;
    private readonly IList<double> _operands;

    public Pow()
    {
        _operand1 = 0;
        _operand2 = 0;
        _operands = new List<double> {_operand1, _operand2};
    }
    
    public double ExecuteOperation()
    {
        var result = Math.Pow(_operand1, _operand2);
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