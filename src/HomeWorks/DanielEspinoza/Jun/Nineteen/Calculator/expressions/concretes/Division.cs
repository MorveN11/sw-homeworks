
namespace Calculator.Expressions;

public class Division : BinaryOperation
{
    public Division(Expr left, Expr right) : base(left, right)
    {}
    public override char Operator => '/';
    protected override double Evaluate(double leftValue, double rightValue)
    {
        if (rightValue == 0)
        {
            throw new DivideByZeroException();
        }
        return leftValue / rightValue;
    }
}

