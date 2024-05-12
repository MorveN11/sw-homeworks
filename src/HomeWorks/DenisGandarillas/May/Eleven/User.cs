namespace src.HomeWorks.DenisGandarillas.May.Eleven
{

  public sealed class User
  {

    private string Name;
    private static User _instance;

    private User(string name)
    {
      Name = name;
    }

    public static User GetInstance(string name)
    {
      if (_instance == null)
      {
        _instance = new User(name);
      }

      return _instance;
    }

    public string GetName()
    {
      return Name;
    }
  }

}