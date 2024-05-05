namespace HomeWorks.DenisGandarillas.May.Fourth.Strategy
{
  
  public class VerifyValidation {

    public string processValidation (ValidationStrategy strategy) {

      string data = Console.ReadLine();

      return strategy.validator(data)? "It is valid :D" : "It is not valid :c";
    }

  }

}