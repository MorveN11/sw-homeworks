namespace Calculator.Operations.Interfaces;

public interface ISingleOperandOperation : IOperation
{
    double Operate(double a);
}