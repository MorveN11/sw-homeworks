namespace src.HomeWorks.DenisGandarillas.May.Eight.AbstractFactory
{

  public class SuzukiCar : ICar
  {

    public void Build()
    {
      Console.WriteLine("Preparing to build...");
      Thread.Sleep(1000);
      Console.WriteLine("Building Suzuki Car...");
      Thread.Sleep(1000);
      Console.WriteLine("Suzuki Car is ready!");
    }

  }

}