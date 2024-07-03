using Calculator.Operations.Interfaces;
using Calculator.Utils;

namespace Calculator;

public interface ICalculator
{
    public void RegisterOperation(Operation op, IBinaryOperation operation);
    public void RegisterOperation(Operation op, IUnaryOperation operation);
    public double PerformOperation(Operation op, double value1, double value2);
    public double PerformOperation(Operation op, double value);

}