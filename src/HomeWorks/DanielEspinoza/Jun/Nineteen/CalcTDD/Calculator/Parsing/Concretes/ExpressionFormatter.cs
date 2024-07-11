namespace Calculator.Parsing
{
    public class ExpressionFormatter : IFormatter
    {
        private readonly char separator = '&';
        private readonly char termSeparator = ',';

        private readonly INormalizer _normalizer;

        public ExpressionFormatter(INormalizer normalizer)
        {
            _normalizer = normalizer;
        }

        public string Format(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return string.Empty;
            }

            expression = _normalizer.Normalize(expression);

            string[] numbers = ExpressionUtils.ExtractNumbers(expression);
            string[] operators = ExpressionUtils.ExtractOperators(expression);

            return FormatExpression(operators, numbers);
        }

        private string FormatExpression(string[] operators, string[] numbers)
        {
            var expressionData = new ExpressionData(operators, numbers);

            foreach (var op in ExpressionUtils.GetOperators())
            {
                FormatExpressionByOperator(op, expressionData);
            }

            return string.Join("", expressionData.Operators) + separator + string.Join(termSeparator, expressionData.Numbers);
        }

        private void FormatExpressionByOperator(string op, ExpressionData data)
        {
            while (data.TempOperators.Contains(op))
            {
                int index = data.TempOperators.IndexOf(op);

                data.Operators[data.OperatorIndex++] = data.TempOperators[index].ToString();
                if (data.TempNumbers[index] == string.Empty)
                {
                    data.FormatIndex--;
                }
                else
                {
                    data.Numbers[data.FormatIndex] = data.TempNumbers[index];
                }
                data.TempNumbers[index] = string.Empty;

                if (index < data.TempNumbers.Count - 1 && data.TempNumbers[index + 1] != string.Empty)
                {
                    data.Numbers[++data.FormatIndex] = data.TempNumbers[index + 1];
                    data.TempNumbers[index + 1] = string.Empty;
                }

                data.TempOperators[index] = string.Empty;
                ++data.FormatIndex;
            }
        }

        private class ExpressionData
        {
            public string[] Operators { get; }
            public string[] Numbers { get; }
            public List<string> TempOperators { get; }
            public List<string> TempNumbers { get; }
            public int FormatIndex { get; set; }
            public int OperatorIndex { get; set; }

            public ExpressionData(string[] operators, string[] numbers)
            {
                Operators = operators;
                Numbers = numbers;
                TempOperators = new List<string>(operators);
                TempNumbers = new List<string>(numbers);
                FormatIndex = 0;
                OperatorIndex = 0;
            }
        }
    }
}
