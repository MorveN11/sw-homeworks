namespace Calculator.Expressions;

public class Addition : BinaryOperation
{
    public Addition(Expr left, Expr right) : base(left, right)
    {
    }

    public override char Operator => '+';

    protected override double Evaluate(double leftValue, double rightValue)
    {
        return leftValue + rightValue;
    }
}