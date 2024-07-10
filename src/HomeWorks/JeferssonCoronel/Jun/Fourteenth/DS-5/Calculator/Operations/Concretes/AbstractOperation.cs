using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes;

public abstract class AbstractOperation : IExecutor
{
    public abstract void SetParameters(double operand1, double operand2);
    public abstract double ExecuteOperation();
}