namespace TemplateDesignPattern{

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Preparing coffee ....");
        BeverageMaker coffeeMaker = new CoffeeMaker();
        coffeeMaker.MakeBeverage();
        
        Console.WriteLine();

        Console.WriteLine("Preparing tea ....");
        BeverageMaker teaMaker = new TeaMaker();
        teaMaker.SetCustomerWantsExtra(true);
        teaMaker.MakeBeverage();        
    }
}

abstract class BeverageMaker
{
    private bool _isCustomerWantsExtra = false;
    public void MakeBeverage()
    {
        BoilWater();
        AddIngredients();
        PourIntoCup();
        if (_isCustomerWantsExtra)
        {
            AddExtra();
        }
    }

    protected abstract void AddIngredients();
    protected abstract void PourIntoCup();

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    public void SetCustomerWantsExtra(bool isCustomerWantsExtra)
    {
        _isCustomerWantsExtra = isCustomerWantsExtra;
    }
    protected virtual void AddExtra()
    {
        Console.WriteLine("Adding extra ingredient");
    }
}

class CoffeeMaker : BeverageMaker
{
    protected override void AddIngredients()
    {
        Console.WriteLine("Adding coffee powder");
    }

    protected override void PourIntoCup()
    {
        Console.WriteLine("Pouring coffee into cup");
    }
}

class TeaMaker : BeverageMaker
{
    protected override void AddIngredients()
    {
        Console.WriteLine("Adding tea leaves");
    }

    protected override void PourIntoCup()
    {
        Console.WriteLine("Pouring tea into cup");
    }

    protected override void AddExtra(){
        Console.WriteLine("Adding Lemon");
    }
}

}