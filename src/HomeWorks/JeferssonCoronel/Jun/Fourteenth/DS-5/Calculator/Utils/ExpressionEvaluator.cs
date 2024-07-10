using System.Text;
using Calculator.Operations;

namespace Calculator.Utils;

public class ExpressionEvaluator
{
    public bool IsACorrectOperation(string operation)
    {
        var isACorrect = !operation.Where((value, i) => 
            (i % 2 == 0 && !char.IsDigit(value)) || (i % 2 != 0 && char.IsDigit(value))).Any();
        return isACorrect;
    }
    
    public string GetEvaluatedExpression(string operation)
    {
        if (!IsACorrectOperation(operation)) return string.Empty;

        var operatorsInformation = ExtractOperatorsInformation(operation);
        var operandsInformation = ExtractOperandsIndex(operation);
        var result = new StringBuilder();

        foreach (var operatorInfo in operatorsInformation) result.Append(operatorInfo.Value.Symbol);
        
        foreach (var operatorInfo in operatorsInformation)
        {
            AppendOperand(operation, result, operandsInformation, operatorInfo.Key - 1);
            AppendOperand(operation, result, operandsInformation, operatorInfo.Key + 1);
        } return result.ToString();
    }
    
    private void AppendOperand(string operation, StringBuilder result, List<int> indexNumbers, int index)
    {
        if (!indexNumbers.Contains(index)) return;
        result.Append(operation[index]);
        indexNumbers.Remove(index);
    }

    public Dictionary<int, Operator> ExtractOperatorsInformation(string operation)
    {
        var operatorsInfo = new Dictionary<int, Operator>();

        for (var index = 0; index < operation.Length; index++)
        {
            if (index % 2 == 0) continue;
            var op = operation[index].GetOperationBySymbol();
            operatorsInfo.Add(index, new Operator(op.GetSymbol(), op.GetPrecedence()));
        }
        operatorsInfo = operatorsInfo.OrderBy(s => s.Value.Precedence).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        return operatorsInfo;
    }

    public List<int> ExtractOperandsIndex(string operation)
    {
        var indexNumbers = new List<int>();

        for (var index = 0; index < operation.Length; index++)
        {
            if (index % 2 == 0) indexNumbers.Add(index);
        } return indexNumbers;
    }
}