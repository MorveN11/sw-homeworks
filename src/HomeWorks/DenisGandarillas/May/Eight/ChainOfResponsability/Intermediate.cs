namespace src.HomeWorks.DenisGandarillas.May.Eight.ChainOfResponsability
{

  public class Intermediate : Approver
  {

    public override void Process(PurchaseRequest purchase)
    {
      if (purchase.Amount < 50000)
      {
        Console.WriteLine("Intermediate approves the request");
      }
      else
      {
        NextApprover.Process(purchase);
      }
    }

  }

}