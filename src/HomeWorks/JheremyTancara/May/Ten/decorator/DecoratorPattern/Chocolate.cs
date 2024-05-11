public class Chocolate : IBeverage
{
    private IBeverage _beverage;

    public Chocolate(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public string GetDescription()
    {
        return _beverage.GetDescription() + ", with chocolate";
    }

    public double GetCost()
    {
        return _beverage.GetCost() + 1.00;
    }
}
