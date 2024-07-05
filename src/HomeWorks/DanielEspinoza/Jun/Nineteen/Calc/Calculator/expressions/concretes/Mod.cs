namespace Calculator.Expressions;


public class Mod : BinaryOperation
{
    public Mod(Expr left, Expr right) : base(left, right)
    {}
        public override char Operator => '%';

    protected override double Evaluate(double leftValue, double rightValue)
    {
        if (rightValue == 0)
        {
            throw new DivideByZeroException();
        }
        
       return leftValue % rightValue;
    }
}