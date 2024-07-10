using Calculator.Operations;

namespace Calculator.Utils;

public static class MyOperationExtensions
{
    private static readonly Dictionary<Operation, Operator> OperationDetails =
        new()
        {
            { Operation.Add, new Operator( '+', 3) },
            { Operation.Division, new Operator('/', 2) },
            { Operation.Multiplication, new Operator('*', 2) },
            { Operation.Pow, new Operator('^', 1) },
            { Operation.Square, new Operator('√', 1) },
            { Operation.Subtraction, new Operator('-', 3) }
        };
    
    public static char GetSymbol(this Operation operation)
    {
        var operatorInfo = OperationDetails[operation];
        return operatorInfo.Symbol;
    }

    public static int GetPrecedence(this Operation operation)
    {
        var operatorInfo = OperationDetails[operation];
        return operatorInfo.Precedence;
    }
    
    public static Operation GetOperationBySymbol(this char symbol)
    {
        foreach (var operatorDetails in OperationDetails)
        {
            if (operatorDetails.Value.Symbol == symbol) return operatorDetails.Key;
        } throw new ArgumentException($"Invalid operation symbol: {symbol}");
    }
}