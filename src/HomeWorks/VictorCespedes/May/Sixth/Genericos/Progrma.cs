using System;

public class Calculadora<T>
{
    public T Sumar(T a, T b)
    {
        dynamic valorA = a;
        dynamic valorB = b;
        return valorA + valorB;
    }

    public T Restar(T a, T b)
    {
        dynamic valorA = a;
        dynamic valorB = b;
        return valorA - valorB;
    }

    public T Multiplicar(T a, T b)
    {
        dynamic valorA = a;
        dynamic valorB = b;
        return valorA * valorB;
    }

    public T Dividir(T a, T b)
    {
        dynamic valorA = a;
        dynamic valorB = b;
        if (valorB == 0)
        {
            throw new ArgumentException("No se puede dividir por cero.");
        }
        return valorA / valorB;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculadora<int> calculadoraEnteros = new Calculadora<int>();
        Console.WriteLine("Suma: " + calculadoraEnteros.Sumar(5, 3));
        Console.WriteLine("Resta: " + calculadoraEnteros.Restar(5, 3));
        Console.WriteLine("Multiplicación: " + calculadoraEnteros.Multiplicar(5, 3));
        Console.WriteLine("División: " + calculadoraEnteros.Dividir(6, 3));

        Calculadora<double> calculadoraDoubles = new Calculadora<double>();
        Console.WriteLine("Suma: " + calculadoraDoubles.Sumar(5.5, 3.3));
        Console.WriteLine("Resta: " + calculadoraDoubles.Restar(5.5, 3.3));
        Console.WriteLine("Multiplicación: " + calculadoraDoubles.Multiplicar(5.5, 3.3));
        Console.WriteLine("División: " + calculadoraDoubles.Dividir(6.6, 3.3));
    }
}
