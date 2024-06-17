using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes;

public class Pow : IMoreThanOneOperandOperation
{
    public string GetSymbol()
    {
        return "^";
    }

    public double Operate(double a, double b, params double[] others)
    {
        var result = Math.Pow(a, b);
        foreach (var num in others) result = Math.Pow(result, num);
        return result;
    }
}