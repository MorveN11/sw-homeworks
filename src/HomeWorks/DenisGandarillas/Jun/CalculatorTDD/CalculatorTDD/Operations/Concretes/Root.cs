namespace CalculatorTDD
{
    public class Root : Operation
    {
        public override double Execute(double numberOne, double numberTwo)
        {
            return Math.Pow(numberOne, 1.0 / numberTwo);
        }
    }
}
