namespace Calculator.Expressions;

public abstract class BinaryOperation : IExpression
{
    public IExpression Left { get; init; }
    public IExpression Right { get; init; }
    public abstract char Operator { get; }

    protected BinaryOperation(IExpression  left, IExpression right)
    {
        Left = left;
        Right = right;
    }

    public double Evaluate()
    {
        double left = Left.Evaluate();
        double right = Right.Evaluate();

        return EvaluateExpression(left, right);
    }
    protected abstract double EvaluateExpression(double left, double right);


    public override string ToString()
    {
        return $"{Left} {Operator} {Right}";
    }
}
