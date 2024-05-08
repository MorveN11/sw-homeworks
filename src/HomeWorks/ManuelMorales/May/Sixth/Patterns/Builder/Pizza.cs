public class Pizza
{
    private readonly List<string> _toppings;

    public Pizza()
    {
        _toppings = new List<string> { "Cheese", "Tomato Sauce", "Dough" };
    }

    public List<string> Toppings => _toppings;

    public void AddTopping(string topping)
    {
        _toppings.Add(topping);
    }

    public override string ToString()
    {
        return $"Pizza with {string.Join(", ", _toppings)}";
    }
}
