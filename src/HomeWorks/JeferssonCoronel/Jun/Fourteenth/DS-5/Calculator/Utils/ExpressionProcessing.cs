namespace Calculator.Utils;

public class ExpressionProcessing
{
    public List<Operation> GetOperatorsFromExpression(string evaluatedExpression)
    {
        var operators = (from character in evaluatedExpression where !char.IsDigit(character) 
            select character.GetOperationBySymbol()).ToList();
        
        return operators;
    }
    
    public List<int> GetOperandsFromExpression(string evaluatedExpression)
    {
        var operands = (from character in evaluatedExpression where char.IsDigit(character) 
            select (int)char.GetNumericValue(character)).ToList();

        return operands;
    }
}