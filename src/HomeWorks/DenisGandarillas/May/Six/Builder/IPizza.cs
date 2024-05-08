namespace HomeWorks.DenisGandarillas.May.Six.Builder
{

  public interface IPizzaBuilder
  {
    void BuildType();
    void BuildTomatoSauce();
    void BuildCheese();
    void BuildToppings();
    Pizza GetPizza();
  }

}