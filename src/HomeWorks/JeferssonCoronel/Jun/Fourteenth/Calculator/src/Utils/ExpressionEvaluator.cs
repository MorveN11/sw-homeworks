using System.Text;

namespace Calculator.Utils;

public class ExpressionEvaluator
{
    public bool IsACorrectOperation(string operation)
    {
        for (var i = 0; i < operation.Length; i++)
        {
            var value = operation[i];
            if (i % 2 == 0 && !char.IsDigit(value)) 
                return false;
            if (i % 2 != 0 && char.IsDigit(value)) 
                return false;
        } return true;
    }
    
    public string GetEvaluatedExpression(string operation)
    {
        if (!IsACorrectOperation(operation)) return string.Empty;

        var (symbols, indexNumbers) = ExtractSymbolsAndIndices(operation);
        var result = new StringBuilder();

        foreach (var symbol in symbols) 
            result.Append(symbol.symbol);
        
        foreach (var symbol in symbols)
        {
            var currentIndex = symbol.index;

            AppendOperand(operation, result, indexNumbers, currentIndex - 1);
            AppendOperand(operation, result, indexNumbers, currentIndex + 1);
        }

        return result.ToString();
    }

    private (List<(int index, int predence, char symbol)>, List<int>) ExtractSymbolsAndIndices(
        string operation)
    {
        var symbols = new List<(int index, int predence, char symbol)>();
        var indexNumbers = new List<int>();

        for (var index = 0; index < operation.Length; index++)
        {
            if (index % 2 == 0) indexNumbers.Add(index);
            else
            {
                var op = GetOperationFromChar(operation[index]); 
                symbols.Add((index, op.GetPrecedence(), op.GetSymbol()));
            }
        } 
        
        symbols = symbols.OrderBy(s => s.predence).ToList();
        return (symbols, indexNumbers);
    } 
    
    private void AppendOperand(string operation, StringBuilder result, List<int> indexNumbers, int index)
    {
        if (!indexNumbers.Contains(index)) return;
        result.Append(operation[index]);
        indexNumbers.Remove(index);
    }
    
    private Operation GetOperationFromChar(char c)
    {
        return c switch
        {
            '+' => Operation.Add,
            '-' => Operation.Subtraction,
            '*' => Operation.Multiplication,
            '/' => Operation.Division,
            '^' => Operation.Pow,
            '√' => Operation.SquareRoot,
            _ => throw new ArgumentException($"Invalid operation: {c}")
        };
    }
}