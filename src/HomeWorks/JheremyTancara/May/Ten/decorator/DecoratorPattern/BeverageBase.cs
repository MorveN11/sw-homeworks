public class BeverageBase : IBeverage
{
    public string Description { get; protected set; }
    public double BaseCost { get; protected set; }

    public BeverageBase(string description, double baseCost)
    {
        Description = description;
        BaseCost = baseCost;
    }

    public string GetDescription()
    {
        return Description;
    }

    public double GetCost()
    {
        return BaseCost;
    }
}
