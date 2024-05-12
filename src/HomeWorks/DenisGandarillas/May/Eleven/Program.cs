namespace src.HomeWorks.DenisGandarillas.May.Eleven
{

  public class Program
  {
    public static void Main(string[] args)
    {
      User user1 = User.GetInstance("Denis");
      User user2 = User.GetInstance("Flor");

      if (user1 == user2)
      {
        Console.WriteLine($"USER 1: {user1.GetName()} | USER 2: {user2.GetName()}");
      }
      else
      {
        Console.WriteLine("Different users :D");
      }
    }
  }

}