namespace Calculator.Utils;

public static class OperationExtensions
{
    private static readonly Dictionary<Operation, (char Symbol, int Precedence)> OperationDetails =
        new()
        {
            { Operation.Add, ('+', 3) },
            { Operation.Division, ('/', 2) },
            { Operation.Multiplication, ('*', 2) },
            { Operation.Pow, ('^', 1) },
            { Operation.SquareRoot, ('√', 1) },
            { Operation.Subtraction, ('-', 3) }
        };
    
    public static char GetSymbol(this Operation operation)
    {
        return OperationDetails[operation].Symbol;
    }

    public static int GetPrecedence(this Operation operation)
    {
        return OperationDetails[operation].Precedence;
    }
}