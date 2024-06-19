using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes;

public class SquareRoot : ISingleOperandOperation
{
    public string GetSymbol()
    {
        return "√";
    }

    public double Operate(double a)
    {
        if (a < 0) throw new ArgumentException("Cannot take square root of a negative number.");
        return Math.Sqrt(a);
    }
}