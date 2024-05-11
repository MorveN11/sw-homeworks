public class Kitchen
{
    private IPizzaBuilder _pizzaBuilder;

    public Kitchen(IPizzaBuilder pizzaBuilder)
    {
        _pizzaBuilder = pizzaBuilder;
    }

    public void PreparePizza()
    {
        _pizzaBuilder.BuildType();
        _pizzaBuilder.BuildDough();
        _pizzaBuilder.BuildSauce();
        _pizzaBuilder.BuildCheese();
        _pizzaBuilder.BuildToppings();
    }

    public Pizza GetPizza()
    {
        return _pizzaBuilder.GetPizza();
    }
}
