namespace CalculatorTDD
{

    public abstract class Operation : IOperation
    {
        public abstract double Execute(double numberOne, double numberTwo);
    }

}
