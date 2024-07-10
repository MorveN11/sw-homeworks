using Calculator.Utils;

namespace Calculator.Operations.Concretes;

public class Multiplication : AbstractOperation
{
    private double _operand1;
    private double _operand2;

    public Multiplication(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }

    public Multiplication()
    {
    }
    
    public override double ExecuteOperation()
    {
        var result = _operand1 * _operand2;
        return result;
    }
    public override void SetParameters(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }
}