namespace HomeWorks.DenisGandarillas.May.Ten
{
  
  public class Program
  {

    public static void Main(string[] args)
    {
      IAccount account = new Account(5425, "Florencia");
      IAccount account2 = new Account(1524, "Denis");
      IAccount account3 = new Account(4225, "Camila");
      IAccount account4 = new Account(6524, "Leonardo");

      IAccount amount = new AmountDecorator(account, 10000);
      IAccount amount2 = new AmountDecorator(account2, 200);
      IAccount amount3 = new AmountDecorator(account3, 3000);
      IAccount amount4 = new AmountDecorator(account4, 5000);

      amount.ShowInformation();
      amount2.ShowInformation();
      amount3.ShowInformation();
      amount4.ShowInformation();
    }

  }

}