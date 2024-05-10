namespace src.HomeWorks.DenisGandarillas.May.Eight.ChainOfResponsability
{

  public class CORDemo
  {
    public void Run()
    {
      var junior = new Junior();
      var intermedate = new Intermediate();
      var manager = new Manager();

      junior.SetNextApprover(intermedate);
      intermedate.SetNextApprover(manager);

      var purchase = new PurchaseRequest(10000);
      junior.Process(purchase);

      purchase = new PurchaseRequest(50000);
      junior.Process(purchase);

      purchase = new PurchaseRequest(100000);
      junior.Process(purchase);
    }
  }

}