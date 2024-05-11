class Program
{
    static void Main(string[] args)
    {
        IBeverage beverage = new BeverageBase("Coffee", 2.00);

        beverage = new Milk(beverage);
        beverage = new Chocolate(beverage);

        Customer customer = new Customer();
        customer.OrderBeverage(beverage);

        Console.ReadKey();
    }
}
