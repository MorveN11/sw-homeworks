using System;

class Program
{
    static void Main(string[] args)
    {
        IProduct productA = Factory.CreateProduct("A");
        productA.Operation();

        IProduct productB = Factory.CreateProduct("B");
        productB.Operation();

        Console.ReadKey();
    }
}
