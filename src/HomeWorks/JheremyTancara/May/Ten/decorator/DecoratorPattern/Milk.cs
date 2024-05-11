public class Milk : IBeverage
{
    private IBeverage _beverage;

    public Milk(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public string GetDescription()
    {
        return _beverage.GetDescription() + ", with milk";
    }

    public double GetCost()
    {
        return _beverage.GetCost() + 0.50;
    }
}
