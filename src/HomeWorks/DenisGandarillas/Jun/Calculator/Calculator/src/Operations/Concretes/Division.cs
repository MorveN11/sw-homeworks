using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes
{

    public class Division : IOperationWithNValues
    {
        public char GetOperator()
        {
            return '/';
        }

        public double Operation(double value, double value2, params double[] values)
        {
            double result = value / value2;
            foreach (var item in values)
            {
                result /= item;
            }
            return result;
        }
    }

}
