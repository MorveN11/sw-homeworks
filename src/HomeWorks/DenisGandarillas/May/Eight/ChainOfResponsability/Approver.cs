namespace src.HomeWorks.DenisGandarillas.May.Eight.ChainOfResponsability
{

  public abstract class Approver : IApprover
  {

    protected IApprover NextApprover;

    public void SetNextApprover(IApprover nextApprover)
    {
      NextApprover = nextApprover;
    }

    public abstract void Process(PurchaseRequest purchase);
  }

}