namespace HomeWorks.DenisGandarillas.May.Six.Builder
{

  public class Pizza
  {

    public string? Type { get; set; }
    public bool HasTomatoSauce { get; set; }
    public bool HasCheese { get; set; }
    public bool HasToppings { get; set; }

    public void Display()
    {
      Console.WriteLine($"Pizza {Type} with tomato sauce: {HasTomatoSauce}, cheese: {HasCheese}, toppings: {HasToppings}");
    }

  }

}