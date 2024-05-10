namespace src.HomeWorks.DenisGandarillas.May.Eight.ChainOfResponsability
{
    public class Manager : Approver
    {
        public override void Process(PurchaseRequest purchase)
        {
            if (purchase.Amount < 100000)
            {
                Console.WriteLine("Manager approves the request");
            }
            else if (NextApprover != null)
            {
                NextApprover.Process(purchase);
            }
            else
            {
                Console.WriteLine("No one can handle the request.");
            }
        }
    }
}
