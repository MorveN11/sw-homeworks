namespace HomeWorks.DenisGandarillas.May.Six.Factory
{

  public class PepperoniPizza : IPizza
  {

    public void Prepare()
    {
      Console.WriteLine("Preparing Pepperoni Pizza...");
      Thread.Sleep(1000);
    }

    public void Bake()
    {
      Console.WriteLine("Baking Pepperoni Pizza...");
      Thread.Sleep(1000);
    }

    public void Cut()
    {
      Console.WriteLine("Cutting Pepperoni Pizza...");
      Thread.Sleep(1000);
    }

    public void Box()
    {
      Console.WriteLine("Boxing Pepperoni Pizza...");
      Thread.Sleep(1000);
      Console.WriteLine("Pepperoni Pizza is ready!");
    }

  }


}