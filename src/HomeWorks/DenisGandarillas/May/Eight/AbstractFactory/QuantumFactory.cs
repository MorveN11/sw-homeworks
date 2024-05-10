namespace src.HomeWorks.DenisGandarillas.May.Eight.AbstractFactory
{
  
  public class QuantumFactory : IFactory
  {

    public ICar CreateCar()
    {

      return new QuantumCar();

    }

  }

}