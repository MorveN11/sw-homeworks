namespace src.HomeWorks.DenisGandarillas.May.Eight.AbstractFactory
{
  
  public class AbstractFactory
  {

    private ICar car;

    public Run()
    {
      
      Console.Clear();
      Console.WriteLine("BUILDING CARS\nOptions:\n1. Quantum\n2. Suzuki\n3. Exit");

      byte option = 0;

      option = Console.ReadLine();

    }

    public Create(IFactory factory)
    {

      car = factory.CreateCar();

    }

    public BuildCar()
    {
      car.Build();
    }

  }

}