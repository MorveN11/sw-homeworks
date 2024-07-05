namespace Calculator.Expressions;

public abstract class BinaryOperation : Expr
    {
        public Expr Left { get; }
        public Expr Right { get; }
        public abstract char Operator { get; }

        protected BinaryOperation(Expr left, Expr right)
        {
            Left = left;
            Right = right;
        }

    public double Evaluate()
    {
        double leftValue = Left.Evaluate();
        double rightValue = Right.Evaluate();
        return Evaluate(leftValue, rightValue);
    }

    protected abstract double Evaluate(double leftValue, double rightValue);

}