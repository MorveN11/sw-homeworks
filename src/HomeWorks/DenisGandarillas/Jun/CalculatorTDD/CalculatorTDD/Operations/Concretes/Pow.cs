namespace CalculatorTDD
{
    public class Pow : Operation
    {
        public override double Execute(double numberOne, double numberTwo)
        {
            return Math.Pow(numberOne, numberTwo);
        }
    }
}
