namespace Calculator.Expressions;


public class Multiplication : BinaryOperation
{
    public Multiplication(IExpression left, IExpression right) : base(left, right)
    { }
    public override char Operator => '*';

    protected override double EvaluateExpression(double leftValue, double rightValue)
    {
        return leftValue * rightValue;
    }
}
