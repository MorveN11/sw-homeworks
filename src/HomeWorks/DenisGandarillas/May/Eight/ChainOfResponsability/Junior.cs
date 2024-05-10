namespace src.HomeWorks.DenisGandarillas.May.Eight.ChainOfResponsability
{

  public class Junior : Approver
  {

    public override void Process(PurchaseRequest purchase)
    {
      if (purchase.Amount < 10000)
      {
        Console.WriteLine("Junior approves the request");
      }
      else
      {
        NextApprover.Process(purchase);
      }
    }

  }

}