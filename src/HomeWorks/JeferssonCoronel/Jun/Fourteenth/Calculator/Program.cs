using Calculator.Utils;

namespace Calculator;

public static class Program
{
    public static void Main()
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.PerformOperation(Operation.Add, 1, 3));
        Console.WriteLine(calculator.PerformOperation(Operation.Subtraction, 3, 1));
        Console.WriteLine(calculator.PerformOperation(Operation.Multiplication, 5, 9));
        Console.WriteLine(calculator.PerformOperation(Operation.Division, 10, 2));
        Console.WriteLine(calculator.PerformOperation(Operation.Pow, 5, 2));
        Console.WriteLine(calculator.PerformOperation(Operation.SquareRoot, 25));
        
        var stringValidator = new ExpressionEvaluator();
        Console.WriteLine(stringValidator.IsACorrectOperation("2+2**8") == false);
        Console.WriteLine(stringValidator.IsACorrectOperation("2+2-8*4") == true);
        Console.WriteLine(stringValidator.GetEvaluatedExpression("2+3*4") == "*+342");
        Console.WriteLine(stringValidator.GetEvaluatedExpression("2+3-4") == "+-234");

        double a = calculator.PerformExpressionCalculation("2+3*6/2");
        Console.WriteLine(a);
    }
}