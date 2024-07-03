namespace Calculator.Utils;

public class ExpressionProcessing
{
    public (List<Operation> operators, List<int> operands) GetOperationsDividedInOperatorsAndOperands(string evaluatedExpression)
    {
        var operators = new List<Operation>();
        var operands = new List<int>();
        
        foreach (var character in evaluatedExpression)
        {
            if (char.IsDigit(character)) 
                operands.Add((int)char.GetNumericValue(character));
            else
            {
                var op = character.GetOperationBySymbol();
                operators.Add(op);
            }
        } return (operators, operands);
    }
}