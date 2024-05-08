namespace HomeWorks.DenisGandarillas.May.Six.Builder
{

  public class BuilderDemo
  {

    public void run()
    {
      PizzaDirector director = new PizzaDirector();
      IPizzaBuilder pepperoniBuilder = new PepperoniPizza();
      director.Constructor(pepperoniBuilder);
      Pizza pizza = pepperoniBuilder.GetPizza();
      pizza.Display();
    }

  }

}