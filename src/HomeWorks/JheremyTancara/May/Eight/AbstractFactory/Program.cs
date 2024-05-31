using System;

interface IChair
{
    void SitOn();
}

interface ISofa
{
    void RelaxOn();
}

class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair.");
    }
}

class VictorianSofa : ISofa
{
    public void RelaxOn()
    {
        Console.WriteLine("Relaxing on a Victorian sofa.");
    }
}

class ModernChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a modern chair.");
    }
}

class ModernSofa : ISofa
{
    public void RelaxOn()
    {
        Console.WriteLine("Relaxing on a modern sofa.");
    }
}

interface IFurnitureFactory
{
    IChair CreateChair();
    ISofa CreateSofa();
}

class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ISofa CreateSofa()
    {
        return new VictorianSofa();
    }
}

class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new ModernChair();
    }

    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }
}

class Client
{
    private readonly IChair _chair;
    private readonly ISofa _sofa;

    public Client(IFurnitureFactory factory)
    {
        _chair = factory.CreateChair();
        _sofa = factory.CreateSofa();
    }

    public void SitAndRelax()
    {
        _chair.SitOn();
        _sofa.RelaxOn();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();
        Client victorianClient = new Client(victorianFactory);
        victorianClient.SitAndRelax();

        IFurnitureFactory modernFactory = new ModernFurnitureFactory();
        Client modernClient = new Client(modernFactory);
        modernClient.SitAndRelax();
    }
}
