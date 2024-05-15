using System;
using System.Collections.Generic;

public interface IFibonacciComponent
{
    int Calculate();
}

public class FibonacciLeaf : IFibonacciComponent
{
    private int _number;

    public FibonacciLeaf(int number)
    {
        _number = number;
    }

    public int Calculate()
    {
        if (_number == 0 || _number == 1)
        {
            return _number;
        }
        else
        {
            int a = 0;
            int b = 1;
            int result = 0;
            for (int i = 2; i <= _number; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
    }
}


public class FibonacciComposite : IFibonacciComponent
{
    private List<IFibonacciComponent> _children = new List<IFibonacciComponent>();

    public void Add(IFibonacciComponent component)
    {
        _children.Add(component);
    }

    public int Calculate()
    {
        int sum = 0;
        foreach (var component in _children)
        {
            sum += component.Calculate();
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        FibonacciComposite composite = new FibonacciComposite();
        for (int i = 0; i < 10; i++)
        {
            composite.Add(new FibonacciLeaf(i));
        }

        int result = composite.Calculate();
        Console.WriteLine("The result of the Fibonacci sequence is: " + result);
    }
}
