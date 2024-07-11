namespace CalculatorTDD
{
    public class Division : Operation
    {
        public override double Execute(double numberOne, double numberTwo)
        {
            if (numberTwo is 0)
            {
                throw new DivideByZeroException("Cannot divide by zero :c");
            }
            return numberOne / numberTwo;
        }
    }
}
