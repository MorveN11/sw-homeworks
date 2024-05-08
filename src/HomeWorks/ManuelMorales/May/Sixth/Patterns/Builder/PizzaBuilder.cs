public class PizzaBuilder : IBuilder
{
    private Pizza _pizza;

    public PizzaBuilder()
    {
        _pizza = new Pizza();
    }

    public void Reset()
    {
        _pizza = new Pizza();
    }

    public IBuilder AddPepperoni()
    {
        _pizza.AddTopping("Pepperoni");
        return this;
    }

    public IBuilder AddPineapple()
    {
        _pizza.AddTopping("Pineapple");
        return this;
    }

    public IBuilder AddBacon()
    {
        _pizza.AddTopping("Bacon");
        return this;
    }

    public IBuilder AddMushrooms()
    {
        _pizza.AddTopping("Mushrooms");
        return this;
    }

    public Pizza Build()
    {
        Pizza pizza = _pizza;
        this.Reset();

        return pizza;
    }
}
