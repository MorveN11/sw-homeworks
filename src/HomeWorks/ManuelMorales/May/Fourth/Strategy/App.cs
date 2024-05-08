public class App
{
    public static void Main(string[] args)
    {
        var calculator = new Calculator();

        Console.WriteLine("Enter first number:");

        var firstNumberInput = Console.ReadLine();

        if (firstNumberInput == null)
        {
            throw new System.Exception("First number not provided");
        }

        var firstNumber = Int32.Parse(firstNumberInput);

        Console.WriteLine("Enter second number:");

        var secondNumberInput = Console.ReadLine();

        if (secondNumberInput == null)
        {
            throw new System.Exception("Second number not provided");
        }

        var secondNumber = Int32.Parse(secondNumberInput);

        Console.WriteLine("Enter operation (+, -, *):");

        var operation = Console.ReadLine();

        if (operation == "+")
        {
            calculator.SetStrategy(new AddMathematicStrategy());
        }
        else if (operation == "-")
        {
            calculator.SetStrategy(new SubtractMathematicStrategy());
        }
        else if (operation == "*")
        {
            calculator.SetStrategy(new MultiplyMathematicStrategy());
        }
        else
        {
            throw new System.Exception("Operation not supported");
        }

        Console.WriteLine(calculator.Calculate(firstNumber, secondNumber));
    }
}
