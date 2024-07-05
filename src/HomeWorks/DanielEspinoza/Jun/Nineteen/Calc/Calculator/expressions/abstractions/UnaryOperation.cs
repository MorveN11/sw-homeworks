namespace Calculator.Expressions;

public abstract class UnaryOperation : Expr
{
    public Expr Operand { get; }
    public abstract char Operator {get;}

    protected UnaryOperation(Expr operand)
    {
        Operand = operand;
    }

    public double Evaluate()
    {
        double operandValue = Operand.Evaluate();
        return Evaluate(operandValue);
    }

    protected abstract double Evaluate(double operandValue);
}