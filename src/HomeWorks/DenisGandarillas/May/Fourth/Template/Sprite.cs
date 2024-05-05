namespace HomeWorks.DenisGandarillas.May.Fourth.Template
{

  public class Sprite : Soda
  {
    public Sprite(string name, string flavor, int price) : base(name, flavor, price)
    {
    }

    protected override void addingIngredients()
    {
      Console.WriteLine("Adding ingredients to " + getName() + ":");
      Console.WriteLine("- Carbonated water");
      Thread.Sleep(1000);
      Console.WriteLine("- High fructose corn syrup");
      Thread.Sleep(1000);
      Console.WriteLine("- Natural lemon-lime flavors");
      Thread.Sleep(1000);
      Console.WriteLine("- Citric acid");
      Thread.Sleep(1000);
      Console.WriteLine("- Sodium citrate");
      Thread.Sleep(1000);
      Console.WriteLine("- Sodium benzoate (to preserve freshness)");
      Thread.Sleep(1000);
      Console.WriteLine("- Caffeine (for caffeine-containing variants)");
      Thread.Sleep(1000);
      Console.WriteLine("- Modified food starch");
      Thread.Sleep(1000);
      Console.WriteLine("- Calcium disodium EDTA (to protect flavor)");
      Thread.Sleep(1000);
      Console.WriteLine("- Yellow 5");
      Thread.Sleep(5000);
    }

    protected override void bottlingSoda()
    {
      Console.WriteLine("Bottling " + getName() + "...");
      Thread.Sleep(5000);
    }

    protected override void calculatingEarnings()
    {
      Random random = new Random();

      int quantitySolds = random.Next(1, 11);

      Console.WriteLine(getName() + "solds: " + quantitySolds);

      int earnings = quantitySolds * getPrice();

      Console.WriteLine("Total earnings -> " + earnings + "$");
    }

    protected override void mixingIngredients()
    {
      Console.WriteLine("Mixing " + getName() + "...");
      Thread.Sleep(5000);
    }

    protected override void sellingSoda()
    {
      Console.WriteLine("Selling " + getName() + "...");
      Thread.Sleep(5000);
    }
  }

}