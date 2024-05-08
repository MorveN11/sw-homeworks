namespace HomeWorks.DenisGandarillas.May.Six.Factory
{

  public class CheesePizza : IPizza
  {
    public void Prepare()
    {
      Console.WriteLine("Preparing Cheese Pizza...");
      Thread.Sleep(1000);
    }

    public void Bake()
    {
      Console.WriteLine("Baking Cheese Pizza...");
      Thread.Sleep(1000);
    }

    public void Cut()
    {
      Console.WriteLine("Cutting Cheese Pizza...");
      Thread.Sleep(1000);
    }

    public void Box()
    {
      Console.WriteLine("Boxing Cheese Pizza...");
      Thread.Sleep(1000);
      Console.WriteLine("Cheese Pizza is ready!");
    }
  }

}