using Calculator.Utils;

namespace Calculator.Operations.Concretes;

public class Pow : AbstractOperation
{
    private double _operand1;
    private double _operand2;

    public Pow(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }

    public Pow()
    {
    }
    
    public override double ExecuteOperation()
    {
        var result = Math.Pow(_operand1, _operand2);
        return result;
    }
    
    public override void SetParameters(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }
}