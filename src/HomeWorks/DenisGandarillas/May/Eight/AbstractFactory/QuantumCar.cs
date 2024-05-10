namespace src.HomeWorks.DenisGandarillas.May.Eight.AbstractFactory
{

  public class QuantumCar : ICar
  {

    public void Build()
    {
      Console.WriteLine("Preparing to build...");
      Thread.Sleep(1000);
      Console.WriteLine("Building Quantum Car...");
      Thread.Sleep(1000);
      Console.WriteLine("Quantum Car is ready!");
    }

  }

}