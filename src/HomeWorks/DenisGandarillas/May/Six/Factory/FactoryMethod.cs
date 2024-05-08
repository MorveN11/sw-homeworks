namespace HomeWorks.DenisGandarillas.May.Six.Factory
{

  public class FactoryMethod
  {

    public void run()
    {

      PizzaCreator pizza1 = new PepperoniPizzaCreator();
      pizza1.OrderPizza();

      Console.WriteLine("================================================================");

      PizzaCreator pizza2 = new CheesePizzaCreator();
      pizza2.OrderPizza();

    }

  }

}