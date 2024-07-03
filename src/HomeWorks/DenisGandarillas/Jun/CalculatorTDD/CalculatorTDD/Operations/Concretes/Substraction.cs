namespace CalculatorTDD
{

    public class Substraction : IOperationWithTwoParams
    {
        public int Execute(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public char GetOperator()
        {
            return '-';
        }
    }

}
