using System;

class Program
{
    static void Main(string[] args)
    {
        IPizzaBuilder builder = new MargaritaPizzaBuilder();
        Kitchen kitchen = new Kitchen(builder);

        kitchen.PreparePizza();
        Pizza pizza = kitchen.GetPizza();

        Console.WriteLine(pizza);

        Console.ReadKey();
    }
}
