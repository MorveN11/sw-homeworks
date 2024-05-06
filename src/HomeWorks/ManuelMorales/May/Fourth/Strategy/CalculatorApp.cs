namespace HomeWorks.ManuelMorales.May.Fourth.Strategy
{
    public class CalculatorApp
    {
        public static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine("Enter two numbers and an operation (+, -, *):");

            var firstNumber = Int32.Parse(Console.ReadLine());
            var secondNumber = Int32.Parse(Console.ReadLine());
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
}
