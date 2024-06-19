namespace Calculator.Expressions;


public class Negation : UnaryOperation
{
    public Negation(Expr operand) : base(operand)
    {}

    public override char Operator => '-';

    protected override double Evaluate(double operandValue)
    {
        return -operandValue;
    }
}