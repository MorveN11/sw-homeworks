namespace HomeWorks.DenisGandarillas.May.Fourth.Template
{

  public class TemplateDemo
  {

    public void run()
    {

      bool run = true;
      Soda soda = null;

      while (run)
      {
        Console.Clear();
        
        Console.WriteLine("Welcome to the selling system");

        Console.WriteLine("Options for sell:\n1. Pepsi\n2. Fanta orange\n3. Fanta Lemon\n4. Sprite\n5. Exit");

        string option = "";

        do
        {
          Console.WriteLine("Select an option:");
          option = Console.ReadLine();
        }
        while (string.IsNullOrEmpty(option));

        if (option == "5")
        {
          run = false;
          continue;
        }
        else if (option == "1")
        {
          soda = new Pepsi("Pepsi", "Pepsi", 10);
        }
        else if (option == "2")
        {
          soda = new FantaOrange("Fanta", "Orange", 9);
        }
        else if (option == "3")
        {
          soda = new FantaLemon("Fanta", "Lemon", 11);
        }
        else if (option == "4")
        {
          soda = new Sprite("Sprite", "Lime-Lemon", 12);
        }
        else
        {
          Console.WriteLine("Invalid option");
          continue;
        }

        if (soda != null)
        {
          soda.create();
        }

        string answer = "Y";

        Console.WriteLine("Do you want to continue[Y] or exit[N] the system?[Y is default]:");

        answer = Console.ReadLine();

        if (answer == "N" || answer == "n")
        {
          run = false;
        }
      }
    }
  }
}
