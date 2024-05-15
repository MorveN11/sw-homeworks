using System.Text.RegularExpressions;

namespace src.HomeWorks.DenisGandarillas.May.Thirdten.Search
{

  public class Program
  {
    public static void Main(string[] args)
    {
      bool run = true;
      Console.Clear();
      while (run)
      {
        Console.Write("Search (or ':q' to exit): ");
        string word = "";
        word = Console.ReadLine();
        if (word != ":q")
        {
          string file = "example.md";
          string text = File.ReadAllText(file);

          MatchCollection matches = Regex.Matches(text, @"\b" + Regex.Escape(word) + @"\b", RegexOptions.IgnoreCase);

          Console.WriteLine("Matches:");
          foreach (Match match in matches)
          {
            Console.WriteLine($"{match.Value} | {match.Index}");
            Thread.Sleep(300);
          }
        }
        else
        {
          run = false;
          Thread.Sleep(300);
          Console.WriteLine("Exiting...");
        }
      }
    }
  }

}