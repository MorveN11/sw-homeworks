namespace HomeWorks.DenisGandarillas.May.Six.Factory
{

  public class PepperoniPizzaCreator : PizzaCreator
  {
    public override IPizza CreatePizza()
    {
      return new PepperoniPizza();
    }
  }

}