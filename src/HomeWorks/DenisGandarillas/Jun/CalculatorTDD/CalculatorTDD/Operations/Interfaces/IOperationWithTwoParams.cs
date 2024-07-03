namespace CalculatorTDD
{

    public interface IOperationWithTwoParams : IOperation
    {
        int Execute(int firstNumber, int secondNumber);
    }

}
