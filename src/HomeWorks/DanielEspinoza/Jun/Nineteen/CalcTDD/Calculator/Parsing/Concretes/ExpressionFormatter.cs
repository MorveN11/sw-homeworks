namespace Calculator.Parsing;

public class ExpressionFormatter : IFormatter
{
    private readonly char separator = '&';
    private readonly char termSeparator = ',';



    public string Format(string expression)
    {
        if (string.IsNullOrEmpty(expression))
        {
            return string.Empty;
        }

        expression = ExpressionUtils.NormalizeExpression(expression);

        string[] numbers = ExpressionUtils.ExtractNumbers(expression);
        string[] operators = ExpressionUtils.ExtractOperators(expression);

        return FormatExpression(operators, numbers);
    }


    private string FormatExpression(string[] operators, string[] numbers)
    {

        List<string> tempOperators = [.. operators];
        List<string> tempNumbers = [.. numbers];
        int formatIndex = 0, operatorIndex = 0;

        foreach (var op in ExpressionUtils.GetOperators())
        {
            FormatExpressionByOperator(op, operators, numbers, tempOperators, tempNumbers, ref formatIndex, ref operatorIndex);
        }

        return string.Join("", operators) + separator + string.Join(termSeparator, numbers);
    }

    private void FormatExpressionByOperator(string op, string[] operators, string[] numbers, List<string> tempOperators, List<string> tempNumbers, ref int formatIndex, ref int operatorIndex)
    {
        while (tempOperators.Contains(op))
        {
            int index = tempOperators.IndexOf(op);

            operators[operatorIndex++] = tempOperators[index].ToString();
            if (tempNumbers[index] == string.Empty)
            {
                formatIndex--;
            }
            else
            {
                numbers[formatIndex] = tempNumbers[index];
            }
            tempNumbers[index] = string.Empty;



            if (index < tempNumbers.Count - 1 && tempNumbers[index + 1] != string.Empty)
            {
                numbers[++formatIndex] = tempNumbers[index + 1];
                tempNumbers[index + 1] = string.Empty;
            }


            tempOperators[index] = string.Empty;
            ++formatIndex;
        }
    }

}
