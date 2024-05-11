namespace HomeWorks.DenisGandarillas.May.Ten
{

  public class AmountDecorator : IAccount
  {

    private IAccount account;
    private decimal amount;

    public AmountDecorator(IAccount account, decimal amount)
    {
      this.account = account;
      this.amount = amount;
    }

    public int Id => account.Id;
    public string Name => account.Name;

    public void ShowInformation()
    {
      account.ShowInformation();
      Console.WriteLine($"\tAMOUNT: {amount}");
    }

  }

}