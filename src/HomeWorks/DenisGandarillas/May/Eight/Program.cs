using src.HomeWorks.DenisGandarillas.May.Eight.AbstractFactory;
using src.HomeWorks.DenisGandarillas.May.Eight.ChainOfResponsability;

namespace src.HomeWorks.DenisGandarillas.May.Eight
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

        Console.WriteLine("Options:\n1. Abstract Factory\n2. Chain of Responsability\n3. Exit");

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
          AFDemo aFDemo = new AFDemo();

          aFDemo.Run();
        }
        else if (option == "2")
        {
          Console.Clear();
          CORDemo cORDemo = new CORDemo();
          cORDemo.Run();
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