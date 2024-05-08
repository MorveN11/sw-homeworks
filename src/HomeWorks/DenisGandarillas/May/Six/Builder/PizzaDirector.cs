namespace HomeWorks.DenisGandarillas.May.Six.Builder
{

  public class PizzaDirector
  {

    public void Constructor(IPizzaBuilder builder)
    {
      builder.BuildType();
      builder.BuildTomatoSauce();
      builder.BuildCheese();
      builder.BuildToppings();
    }

  }

}