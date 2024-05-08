namespace HomeWorks.DenisGandarillas.May.Six.Factory
{
  public abstract class PizzaCreator
  {
    public abstract IPizza CreatePizza();
    public void OrderPizza()
    {
      IPizza pizza = CreatePizza();
      pizza.Prepare();
      pizza.Bake();
      pizza.Cut();
      pizza.Box();
    }
  }
}