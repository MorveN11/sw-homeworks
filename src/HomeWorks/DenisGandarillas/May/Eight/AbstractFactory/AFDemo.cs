namespace src.HomeWorks.DenisGandarillas.May.Eight.AbstractFactory
{

  public class AFDemo
  {

    private IFactory factory;
    private ICar car;

    public void Run()
    {

      bool run = true;

      while (run)
      {
        Console.Clear();
        Console.WriteLine("BUILDING CARS\nOptions:\n1. Quantum\n2. Suzuki\n3. Exit");

        byte option = 0;

        option = byte.Parse(Console.ReadLine());

        if (option == 1)
        {
          factory = new QuantumFactory();
        }
        else if (option == 2)
        {
          factory = new SuzukiFactory();
        }
        else if (option == 3)
        {
          run = false;
          continue;
        }
        else
        {
          continue;
        }

        Create(factory);

        Console.WriteLine("Do you want to continue? Y/N [Y is default]:");

        char answer = 'Y';

        answer = char.Parse(Console.ReadLine());

        if (answer == 'N' || answer == 'n')
        {
          run = false;
        }
      }

    }

    public void Create(IFactory iFactory)
    {

      car = iFactory.CreateCar();

      BuildCar();

    }

    public void BuildCar()
    {
      car.Build();
    }

  }

}