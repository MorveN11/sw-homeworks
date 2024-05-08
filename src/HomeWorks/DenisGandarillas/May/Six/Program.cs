using HomeWorks.DenisGandarillas.May.Six.Builder;
using HomeWorks.DenisGandarillas.May.Six.Factory;

namespace HomeWorks.DenisGandarillas.May.Six
{
  public class Program
  {

    public static void Main(string[] args)
    {

      bool run = true;

      while (run)
      {
        Console.Clear();
        Console.WriteLine("Welcome to the DENIS GANDARILLAS' program :D");

        Console.WriteLine("Options:\n1. Builder\n2. Factory\n3. Exit");

        string option = "";

        do
        {
          Console.WriteLine("Select an option: ");
          option = Console.ReadLine();
        } while (string.IsNullOrEmpty(option));

        if (option == "3")
        {
          run = false;
          continue;
        }
        else if (option == "1")
        {
          Console.Clear();
          BuilderDemo builder = new BuilderDemo();

          builder.run();
        }
        else if (option == "2")
        {
          Console.Clear();
          FactoryMethod factory = new FactoryMethod();

          factory.run();
        }
        else
        {
          continue;
        }

        string answer = "Y";

        Console.WriteLine("Do you want to continue[Y] or exit[N] the DENIS GANDARILLAS' program?[Y is default]: ");

        answer = Console.ReadLine();

        if (answer == "N" || answer == "n")
        {
          run = false;
        }
      }

    }

  }
}