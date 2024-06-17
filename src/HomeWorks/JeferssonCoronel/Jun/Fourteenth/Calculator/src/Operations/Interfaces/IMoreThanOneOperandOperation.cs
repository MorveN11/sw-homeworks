namespace Calculator.Operations.Interfaces;

public interface IMoreThanOneOperandOperation : IOperation
{
    double Operate(double a, double b, params double[] others);
}