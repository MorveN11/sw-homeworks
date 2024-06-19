using Calculator.Operations.Interfaces;

namespace Calculator.Operations.Concretes
{

    public class Pow : IOperationWithNValues
    {
        public char GetOperator()
        {
            return '^';
        }

        public double Operation(double value, double value2, params double[] values)
        {
            double result = Math.Pow(value, value2);
            foreach (var item in values)
            {
                result = Math.Pow(result, item);
            }
            return result;
        }
    }

}
