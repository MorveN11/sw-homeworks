namespace Calculator.Expressions;

public class Number(double value) : IExpression
{
    public double Value { get; init;} = value;

    public double Evaluate() => Value;

    public override string ToString() => Value.ToString();
}
