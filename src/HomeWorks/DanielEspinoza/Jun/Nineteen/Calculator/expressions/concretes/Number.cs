namespace Calculator.Expressions;

public class Number : Expr
{
    public double Value { get; }
    public Number(double value) => Value = value;
    public double Evaluate() => Value;
}