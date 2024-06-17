using Calculator.Operations.Interfaces;

namespace Calculator;

public interface ICalculator
{
    public void RegisterOperation(string name, IOperation operation);
    public double PerformOperation(string name, double value1, double value2, params double[] numbers);
    public double PerformOperation(string name, double value);

}