namespace HomeWorks.DenisGandarillas.May.Ten
{
  
  public class Account : IAccount
  {

    public int Id { get; }
    public string Name { get; }

    public Account(int id, string name)
    {
      Id = id;
      Name = name;
    }

    public void ShowInformation()
    {
      Console.WriteLine($"ACCOUNT:\n\tID: {Id}\n\tNAME: {Name}");
    }

  }

}