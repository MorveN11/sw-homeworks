namespace Recursion
{
    public class App
    {
        static void Main(string[] args)
        {
            MathRecursionContext context = new MathRecursionContext();

            context.setStrategy(new FibonacciStrategy());
            int[] fibonacci = context.getSequence(10);
            System.Console.WriteLine("Fibonacci: " + string.Join(", ", fibonacci));

            context.setStrategy(new LucasStrategy());
            int[] lucas = context.getSequence(10);
            System.Console.WriteLine("Lucas: " + string.Join(", ", lucas));

            context.setStrategy(new TribonacciStrategy());
            int[] tribonacci = context.getSequence(10);
            System.Console.WriteLine("Tribonacci: " + string.Join(", ", tribonacci));
        }
    }
}
