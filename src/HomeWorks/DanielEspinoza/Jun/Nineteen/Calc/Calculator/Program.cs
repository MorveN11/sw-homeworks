namespace Calculator
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            try
            {
                double result = MathCalculator.Calculate(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
