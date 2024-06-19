namespace Calculator.Expressions;


public class Exponentiation : BinaryOperation
{
    public Exponentiation(Expr left, Expr right) : base(left, right)
    {}
    public override char Operator => '^';
    protected override double Evaluate(double leftValue, double rightValue)
    {
       return Math.Pow(leftValue, rightValue);
    }
}