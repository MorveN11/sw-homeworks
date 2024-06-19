using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes
{

    public class SquareRoot : IOperationOneValue
    {
        public char GetOperator()
        {
            return 'r';
        }

        public double Operation(double value)
        {
            return (value < 0) ? throw new ArgumentException("Undefined, It is not valid to take the square root of a number less than 0.") : Math.Sqrt(value);
        }
    }

}
