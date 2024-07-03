using Xunit;

namespace Calculator.Utils;

public static class MyExtensions
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
    
    public static Operation GetOperationBySymbol(this char symbol)
    {
        foreach (var kvp in OperationDetails)
        {
            if (kvp.Value.Symbol == symbol) return kvp.Key;
        } throw new ArgumentException($"Invalid operation symbol: {symbol}");
    }
    
    public static void AssertList<T>(IList<T> expected, IList<T> actual)
    {
        Assert.Equal(expected.Count, actual.Count);

        for (var i = 0; i < expected.Count; i++) Assert.Equal(expected[i], actual[i]);
    }
}