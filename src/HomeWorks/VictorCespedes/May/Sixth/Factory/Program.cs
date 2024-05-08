using System;

interface IProduct
{
    void price();
}

class Chocapic : IProduct
{
    public void price()
    {
        Console.WriteLine("El chocapic cuesta 20 bs");
    }
}

class Fanta : IProduct
{
    public void price()
    {
        Console.WriteLine("La fanta cuesta 9 bs");
    }
}

abstract class Brand
{
    public abstract IProduct createProduct();
}

class Nesstle : Brand
{
    public override IProduct createProduct()
    {
        return new Chocapic();
    }
}

class CocaCola : Brand
{
    public override IProduct createProduct()
    {
        return new Fanta();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Brand fabrica1 = new Nesstle();
        IProduct chocapic = fabrica1.createProduct();
        chocapic.price();

        Brand fabrica2 = new CocaCola();
        IProduct cocacola = fabrica2.createProduct();
        cocacola.price();
    }
}
