using System;
using System.Collections.Generic;
using System.Linq;

interface ISequence : IEnumerable<int> { }

class FibonacciSequence : ISequence
{
    private readonly int _maxElements;

    public FibonacciSequence(int maxElements)
    {
        _maxElements = maxElements;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return GenerateSequence().GetEnumerator();
    }

    private IEnumerable<int> GenerateSequence()
    {
        int prev = 0, curr = 1;
        for (int i = 0; i < _maxElements; i++)
        {
            yield return prev;
            int temp = prev;
            prev = curr;
            curr = temp + curr;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class FactorialSequence : ISequence
{
    private readonly int _maxElements;

    public FactorialSequence(int maxElements)
    {
        _maxElements = maxElements;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return GenerateSequence().GetEnumerator();
    }

    private IEnumerable<int> GenerateSequence()
    {
        int result = 1;
        for (int i = 1; i <= _maxElements; i++)
        {
            result *= i;
            yield return result;
        }
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Fibonacci Sequence:");
        var fibSequence = new FibonacciSequence(10);
        fibSequence.ToList().ForEach(num => Console.Write($"{num} "));

        Console.WriteLine();

        Console.WriteLine("Factorial Sequence:");
        var factSequence = new FactorialSequence(5);
        factSequence.ToList().ForEach(num => Console.Write($"{num} "));
    }
}
