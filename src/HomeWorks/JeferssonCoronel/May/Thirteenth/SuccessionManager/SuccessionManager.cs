namespace HomeWorks.JeferssonCoronel.May.Thirteenth.SuccessionManager.SuccessionManager.cs
{
    /* I am going to use the Strategy Design Pattern the reason of it is the Strategy pattern allows you to define a
    family of algorithms, encapsulate each of them and make them interchangeable. This means that I can have
    different strategies for calculating the next value in the sequence and switch between them without modifying
    the code that uses them. */

    public interface ISuccessionStrategy
    {
        double CalculateNextValue(double currentValue, double prevValue);
    }

    public class GeometricSuccessionStrategy(double reason) : ISuccessionStrategy
    {
        public double CalculateNextValue(double currentValue, double prevValue)
        {
            return currentValue * reason;
        }
    }

    public class FibonacciSuccessionStrategy : ISuccessionStrategy
    {
        public double CalculateNextValue(double currentValue, double prevValue)
        {
            return prevValue + currentValue;
        }
    }

    public class ArithmeticSuccessionStrategy(double difference) : ISuccessionStrategy
    {
        public double CalculateNextValue(double currentValue, double prevValue)
        {
            return currentValue + difference;
        }
    }

    public class SequenceManager(ISuccessionStrategy strategy, double currentValue, double prevValue)
    {
        public void ChangeStrategy(ISuccessionStrategy newStrategy)
        {
            strategy = newStrategy;
        }

        public double GenerateNextValue()
        {
            var nextValue = strategy.CalculateNextValue(currentValue, prevValue);
            prevValue = currentValue;
            currentValue = nextValue;
            return nextValue;
        }
    }

    public static class Program
    {
        private static void Main()
        {
            const int n = 10;

            // Geometric Sequence
            var geometricManager = new SequenceManager(new GeometricSuccessionStrategy(2), 3, 0);
            Console.WriteLine("- Geometric Sequence:");
            for (var i = 1; i < n; i++)
            {
                Console.Write(geometricManager.GenerateNextValue() + ", ");
            }

            // Fibonacci Sequence
            var fibonacciManager = new SequenceManager(new FibonacciSuccessionStrategy(), 0, 1);
            Console.WriteLine("\n\n- Fibonacci Sequence:");
            for (var i = 1; i < n; i++)
            {
                Console.Write(fibonacciManager.GenerateNextValue() + ", ");
            }

            // Arithmetic Sequence
            var arithmeticManager = new SequenceManager(new ArithmeticSuccessionStrategy(3), 2, 5);
            Console.WriteLine("\n\n- Arithmetic Sequence:");
            for (var i = 1; i < n; i++)
            {
                Console.Write(arithmeticManager.GenerateNextValue() + ", ");
            }

            // Changing Type Sequence
            Console.WriteLine("\n\n- Mixed Sequence Types:");
            var geometricMixedManager = new SequenceManager(new GeometricSuccessionStrategy(2), 3, 0);
            var fibonacciMixedManager = new SequenceManager(new FibonacciSuccessionStrategy(), 21, 13);
            var arithmeticMixedManager = new SequenceManager(new ArithmeticSuccessionStrategy(3), 144, 233);

            for (var i = 1; i < n; i++)
            {
                switch (i)
                {
                    case <= 3:
                        Console.Write(geometricMixedManager.GenerateNextValue() + ", ");
                        break;
                    case <= 6:
                        Console.Write(fibonacciMixedManager.GenerateNextValue() + ", ");
                        break;
                    default:
                        Console.Write(arithmeticMixedManager.GenerateNextValue() + ", ");
                        break;
                }
            }
        }
    }

}
