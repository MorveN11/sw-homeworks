
using Calculator.Expressions;
using Calculator.Parsing;

namespace Calculator.Example
{
    public class Program
    {
        public static void Main()
        {
            IFormatter formatter = new ExpressionFormatter();

            string formattedExpression = formatter.Format("2 / 4 + 3 - 1");

            IParser ps = new ExpressionParser();
            IExpression expressionTree = ps.Parse(formattedExpression);
            System.Console.WriteLine(expressionTree.ToString());
            System.Console.WriteLine(expressionTree.Evaluate());
        }
    }
}
