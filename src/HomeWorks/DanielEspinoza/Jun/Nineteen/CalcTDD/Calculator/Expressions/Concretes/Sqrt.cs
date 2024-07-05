namespace Calculator.Expressions;


public class Sqrt : BinaryOperation
{
    public Sqrt(IExpression left, IExpression right) : base(left, right)
    {}
    public override char Operator => 'S';

    protected override double EvaluateExpression(double leftValue, double rightValue)
    {
        return Math.Sqrt(leftValue);
    }
}
