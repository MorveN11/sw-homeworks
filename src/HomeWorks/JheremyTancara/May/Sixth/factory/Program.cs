using System;

namespace FactoryMethodPattern
{
    abstract class Product
    {
        public abstract void Display();
    }

    class ProductA : Product
    {
        public override void Display()
        {
            Console.WriteLine("Producto A");
        }
    }

    class ProductB : Product
    {
        public override void Display()
        {
            Console.WriteLine("Producto B");
        }
    }

    abstract class Creator
    {
        public abstract Product FactoryMethod();
        public void ShowProduct()
        {
            Product product = FactoryMethod();
            product.Display();
        }
    }

    class CreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ProductA();
        }
    }

    class CreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ProductB();
        }
    }

    class Program
    {
        static void Main()
        {
            Creator creatorA = new CreatorA();
            Creator creatorB = new CreatorB();

            Console.WriteLine("Usando CreatorA:");
            creatorA.ShowProduct();

            Console.WriteLine("\nUsando CreatorB:");
            creatorB.ShowProduct();
        }
    }
}
