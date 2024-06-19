namespace Calculator.Expressions;


public class Multiplication : BinaryOperation
{
    public Multiplication(Expr left, Expr right) : base(left, right)
    { }
    public override char Operator => '*';

    protected override double Evaluate(double leftValue, double rightValue)
    {
        return leftValue * rightValue;
    }
}