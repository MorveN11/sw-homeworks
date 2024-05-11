public class Customer
{
    public void OrderBeverage(IBeverage beverage)
    {
        Console.WriteLine("Description: " + beverage.GetDescription());
        Console.WriteLine("Cost: $" + beverage.GetCost());
    }
}
