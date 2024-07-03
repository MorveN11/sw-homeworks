namespace Calculator.Operations.Interfaces;

public interface IOperation
{
    double ExecuteOperation();
    IList<double> GetOperands();
}