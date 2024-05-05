namespace HomeWorks.DenisGandarillas.May.Fourth.Template {

  public abstract class Soda {

    private string name;
    private string flavor;
    private int price;

    public Soda(string name, string flavor, int price) {
      this.name = name;
      this.flavor = flavor;
      this.price = price;
    }

    public void create() {

      Console.Clear();

      Console.WriteLine("Creating " + name + "...");
      addingIngredients();
      mixingIngredients();
      bottlingSoda();

      Console.WriteLine("Finished creating " + name + "!");

      Console.WriteLine("Now selling " + name + "...");

      sellingSoda();

      calculatingEarnings();
    }

    protected abstract void addingIngredients();

    protected abstract void mixingIngredients();

    protected abstract void bottlingSoda();

    protected abstract void sellingSoda();

    protected abstract void calculatingEarnings();

    public string getName() {
      return name;
    }

    public string getFlavor() {
      return flavor;
    }

    public int getPrice() {
      return price;
    }

  }

}