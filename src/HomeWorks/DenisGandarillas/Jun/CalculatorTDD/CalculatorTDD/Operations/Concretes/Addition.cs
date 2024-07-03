namespace CalculatorTDD
{

    public class Addition : IOperationWithTwoParams
    {
        public int Execute(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public char GetOperator()
        {
            return '+';
        }
    }

}
