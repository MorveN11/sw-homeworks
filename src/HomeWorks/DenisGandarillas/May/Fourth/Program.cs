using System.Formats.Asn1;
using HomeWorks.DenisGandarillas.May.Fourth.Strategy;
using HomeWorks.DenisGandarillas.May.Fourth.Template;

namespace HomeWorks.DenisGandarillas.May.Fourth
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

        Console.WriteLine("Options:\n1. Strategy\n2. Template\n3. Exit");

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
          StrategyDemo strategyDemo = new StrategyDemo();

          strategyDemo.run();
        }
        else if (option == "2")
        {
          TemplateDemo templateDemo = new TemplateDemo();

          templateDemo.run();
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