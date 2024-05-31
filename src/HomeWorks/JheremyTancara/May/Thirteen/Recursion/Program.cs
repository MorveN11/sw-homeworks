using System;
using System.Collections.Generic;

public interface ISequence
{
    IEnumerable<long> GenerateSequence(int n);
}

public class Fibonacci : ISequence
{
    public IEnumerable<long> GenerateSequence(int n)
    {
        long n1 = 0, n2 = 1;
        for (int i = 0; i < n; i++)
        {
            long aux = n1;
            n1 = n2;
            n2 = aux + n1;
            yield return n1;
        }
    }
}

public class Triangular : ISequence
{
    public IEnumerable<long> GenerateSequence(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            yield return (i * (i + 1)) / 2;
        }
    }
}

public class Sequence
{
    private readonly ISequence _algorithm;

    public Sequence(ISequence algorithm)
    {
        _algorithm = algorithm;
    }

    public IEnumerable<long> GenerateSequence(int n)
    {
        return _algorithm.GenerateSequence(n);
    }
}

public class Program
{
    public static void PrintSequence(IEnumerable<long> sequence)
    {
        foreach (var num in sequence)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        var fibonacci = new Sequence(new Fibonacci());
        var triangular = new Sequence(new Triangular());

        Console.WriteLine("Fibonacci:");
        PrintSequence(fibonacci.GenerateSequence(10));

        Console.WriteLine("Triangular:");
        PrintSequence(triangular.GenerateSequence(10));
    }
}
