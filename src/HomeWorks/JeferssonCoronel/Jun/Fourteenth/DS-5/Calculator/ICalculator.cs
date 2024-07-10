using Calculator.Operations.Interfaces;

namespace Calculator;

public interface ICalculator
{
    public void RegisterOperation(Operation op, IOperation operation);
    public double PerformOperation(Operation op, double value1, double value2);
}