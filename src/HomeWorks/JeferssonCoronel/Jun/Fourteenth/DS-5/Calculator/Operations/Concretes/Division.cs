using Calculator.Utils;

namespace Calculator.Operations.Concretes;

public class Division : AbstractOperation
{
    private double _operand1;
    private double _operand2;

    public Division(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }

    public Division()
    {
    }
    
    public override double ExecuteOperation()
    {
        if (_operand2 == 0) throw new DivideByZeroException("Division by zero is not allowed.");
        var result = _operand1 / _operand2;
        return result;
    }
    
    public override void SetParameters(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }
}