using System.Data;

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
        int formatIndex = 0;

         // 2 + 3 * 4
        // 2,3,4
        // +,*


        foreach (var op in ExpressionUtils.GetOperators())
        {
            while (tempOperators.Contains(op))
            {
                int index = tempOperators.IndexOf(op);

                numbers[formatIndex] = tempNumbers[index];
                numbers[formatIndex+1] = tempNumbers[index+1];
                operators[formatIndex] = tempOperators[index].ToString();

                tempNumbers.RemoveAt(index);
                tempOperators.RemoveAt(index);
                formatIndex++;
            }
        }

        numbers[formatIndex] = tempNumbers[0];

        return string.Join("", operators) + separator + string.Join(termSeparator, numbers);
    }

}
