public class App
{
    public static void Main()
    {
        Console.WriteLine("Builder Pattern");

        var director = new RestaurantDirector();
        var pizzaBuilder = new PizzaBuilder();
        director.setBuilder(pizzaBuilder);

        var pizza = pizzaBuilder.Build();
        Console.WriteLine("Simple Pizza:");
        Console.WriteLine(pizza);

        director.BuildCremini();
        pizza = pizzaBuilder.Build();
        Console.WriteLine("Cremini Pizza:");
        Console.WriteLine(pizza);

        director.BuildHawaiian();
        pizza = pizzaBuilder.Build();
        Console.WriteLine("Hawaiian Pizza:");
        Console.WriteLine(pizza);
    }
}
