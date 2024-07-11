using Calculator.Expressions;
using Calculator.Parsing;
using Calculator.Processing;

namespace Calculator.Example
{
    public class Program
    {
        public static void Main()
        {


            ExpressionValidator validator = new();
            ExpressionParser parser = new();
            ExpressionNormalizer normalizer = new();
            ExpressionFormatter formatter = new(normalizer);

            ExpressionProcessor processor = new(formatter, parser, validator);
            string? input = Console.ReadLine();
            if (input != null)
            {
                Console.WriteLine(processor.ProcessExpression(input));
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}

