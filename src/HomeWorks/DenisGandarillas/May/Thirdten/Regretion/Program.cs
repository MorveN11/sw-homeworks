namespace src.HomeWorks.DenisGandarillas.May.Thirdten.Regretion
{
  public class Program
  {

    public static void PrintSequence(IEnumerable<long> sequence)
    {
        foreach (var num in sequence)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
      
      var fibonazi = new Sequence(new Fibonazi());
      var padovan = new Sequence(new Padovan());

      Console.WriteLine("Fibonzi:");
      PrintSequence(fibonazi.GenerateSequence(10));

      Console.WriteLine("Padovan:");
      PrintSequence(padovan.GenerateSequence(10));

    }

  }
}