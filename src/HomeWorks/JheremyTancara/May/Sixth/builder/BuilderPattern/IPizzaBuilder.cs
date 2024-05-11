public interface IPizzaBuilder
{
    void BuildType();
    void BuildDough();
    void BuildSauce();
    void BuildCheese();
    void BuildToppings();
    Pizza GetPizza();
}
