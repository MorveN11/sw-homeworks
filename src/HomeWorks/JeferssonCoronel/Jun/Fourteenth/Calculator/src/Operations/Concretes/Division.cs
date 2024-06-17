using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes;

public class Division : IMoreThanOneOperandOperation
{
    public string GetSymbol()
    {
        return "/";
    }

    public double Operate(double a, double b, params double[] others)
    {
        if (b == 0) throw new DivideByZeroException("Division by zero is not allowed.");
        var result = a / b;
        foreach (var num in others)
        {
            if (num == 0) throw new DivideByZeroException("Division by zero is not allowed.");
            result /= num;
        }
        return result;
    }
}