namespace HomeWorks.DenisGandarillas.May.Six.Factory
{

  public class CheesePizzaCreator : PizzaCreator
  {
    public override IPizza CreatePizza()
    {
      return new CheesePizza();
    }
  }

}