namespace Calculator.Expressions;


public class Exponentiation : BinaryOperation
{
    public Exponentiation(IExpression left, IExpression right) : base(left, right)
    {}
    public override char Operator => '^';
    protected override double EvaluateExpression(double leftValue, double rightValue)
    {
       return Math.Pow(leftValue, rightValue);
    }
}
