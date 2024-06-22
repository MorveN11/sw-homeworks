
using System;

public interface ISequenceStrategy
{
    int GetNextValue(int current, int index);
}

public class FibonacciStrategy : ISequenceStrategy
{
    private int prev = 0;
    private int current = 1;

    public int GetNextValue(int current, int index)
    {
        if (index == 0)
            return prev;
        if (index == 1)
            return current;

        int next = prev + current;
        prev = current;
        current = next;
        return next;
    }
}

public class GeometricStrategy : ISequenceStrategy
{
    private int ratio;

    public GeometricStrategy(int ratio)
    {
        this.ratio = ratio;
    }

    public int GetNextValue(int current, int index)
    {
        if (index == 0)
            return 1;

        return current * ratio;
    }
}

public class SequenceManager
{
    private ISequenceStrategy _strategy;

    public SequenceManager(ISequenceStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(ISequenceStrategy strategy)
    {
        _strategy = strategy;
    }

    public void PrintSequence(int length)
    {
        int current = 0;
        for (int i = 0; i < length; i++)
        {
            current = _strategy.GetNextValue(current, i);
            Console.WriteLine(current);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SequenceManager manager = new SequenceManager(new FibonacciStrategy());
        Console.WriteLine("Fibonacci Sequence:");
        manager.PrintSequence(10);

        manager.SetStrategy(new GeometricStrategy(2));
        Console.WriteLine("\nGeometric Sequence (ratio 2):");
        manager.PrintSequence(10);
    }
}
