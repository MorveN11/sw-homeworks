namespace Calculator.Operations.Interfaces
{

    public interface IOperationWithNValues : IOperation
    {

        double Operation(double value, double value2, params double[] values);

    }

}
