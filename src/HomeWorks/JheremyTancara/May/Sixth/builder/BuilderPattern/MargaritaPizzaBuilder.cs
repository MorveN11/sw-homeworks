public class MargaritaPizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza;

    public MargaritaPizzaBuilder()
    {
        _pizza = new Pizza { Type = "Margarita" };
    }

    public void BuildType()
    {
        _pizza.Type = "Margarita";
    }

    public void BuildDough()
    {
        _pizza.Dough = "Thin";
    }

    public void BuildSauce()
    {
        _pizza.Sauce = "Tomato";
    }

    public void BuildCheese()
    {
        _pizza.Cheese = "Mozzarella";
    }

    public void BuildToppings()
    {
        _pizza.Toppings = "Basil, Tomato";
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}
