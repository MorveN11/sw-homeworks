using Calculator.Operations.Interfaces;
using Calculator.Utils;

namespace Calculator;

public interface ICalculator
{
    public void RegisterOperation(Operation op, IOperation operation);
    public double PerformOperation(Operation op, double value1, double value2, params double[] numbers);
    public double PerformOperation(Operation op, double value);

}