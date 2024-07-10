namespace Calculator;

public class Operator
{
    public int Precedence { get; }
    public char Symbol { get; }

    public Operator(char symbol, int precedence)
    {
        Precedence = precedence;
        Symbol = symbol;
    }
}