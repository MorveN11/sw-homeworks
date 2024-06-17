using Calculator.Operations.Concretes;

namespace Calculator;

public static class Program
{
    public static void Main()
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.PerformOperation("add", 1, 3));
        Console.WriteLine(calculator.PerformOperation("subtract", 3, 1));
        Console.WriteLine(calculator.PerformOperation("multiply", 5, 9));
        Console.WriteLine(calculator.PerformOperation("divide", 10, 2));
        Console.WriteLine(calculator.PerformOperation("pow", 5, 2));
        Console.WriteLine(calculator.PerformOperation("square-root", 25));
    }
}