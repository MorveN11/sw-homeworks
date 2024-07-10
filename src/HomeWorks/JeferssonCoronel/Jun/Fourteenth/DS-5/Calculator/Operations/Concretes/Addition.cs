using Calculator.Utils;

namespace Calculator.Operations.Concretes;

public class Addition : AbstractOperation
{
    
    private double _operand1;
    private double _operand2;

    public Addition(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }

    public Addition() {}
    
    public override double ExecuteOperation()
    {
        var result = _operand1 + _operand2;
        return result;
    }

    public override void SetParameters(double operand1, double operand2)
    {
        _operand1 = operand1;
        _operand2 = operand2;
    }
}