namespace Calculator.Expressions;

public class Subtraction : BinaryOperation
{
    public Subtraction(Expr left, Expr right) : base(left, right)
    {
    }

    public override char Operator => '-';

    protected override double Evaluate(double leftValue, double rightValue)
    {
        return leftValue - rightValue;
    }
}