namespace Calculator.Expressions;


public class Mod : BinaryOperation
{
    public Mod(IExpression left, IExpression right) : base(left, right)
    {}
        public override char Operator => '%';

    protected override double EvaluateExpression(double leftValue, double rightValue)
    {
        if (rightValue == 0)
        {
            throw new DivideByZeroException();
        }

       return leftValue % rightValue;
    }
}
