using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes;

public class Addition : IMoreThanOneOperandOperation
{
    public string GetSymbol()
    {
        return "+";
    }

    public double Operate(double a, double b, params double[] others)
    {
        var result = a + b;
        foreach (var num in others) result += num;
        return result;
    }
}