namespace src.HomeWorks.DenisGandarillas.May.Eight.AbstractFactory
{
  
  public class SuzukiFactory : IFactory
  {

    public ICar CreateCar()
    {
      return new SuzukiCar();
    }

  }

}