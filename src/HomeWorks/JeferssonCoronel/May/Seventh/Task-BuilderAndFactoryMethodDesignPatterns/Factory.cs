namespace HomeWorks.JeffersonCoronel.May.Seventh.Task-BuilderAndFactoryMethodDesignPatterns
{
    internal abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public abstract void Assemble();
        public abstract void Test();
    }

    internal class Car : Vehicle
    {
        public override void Assemble()
        {
            Console.WriteLine($"Assembling a {Make} {Model} car from {Year}.");
        }

        public override void Test()
        {
            Console.WriteLine("Testing the car on the test track.");
        }
    }

    internal class Truck : Vehicle
    {
        public override void Assemble()
        {
            Console.WriteLine($"Assembling a {Make} {Model} truck from {Year}.");
        }

        public override void Test()
        {
            Console.WriteLine("Testing the truck on the load test circuit.");
        }
    }

    internal abstract class VehicleFactory
    {
        protected abstract Vehicle CreateVehicle(string make, string model, int year);

        public void ManufactureVehicle(string make, string model, int year)
        {
            Vehicle vehicle = CreateVehicle(make, model, year);
            vehicle.Assemble();
            vehicle.Test();
        }
    }

    internal class CarFactory : VehicleFactory
    {
        protected override Vehicle CreateVehicle(string make, string model, int year)
        {
            return new Car { Make = make, Model = model, Year = year };
        }
    }

    internal class TruckFactory : VehicleFactory
    {
        protected override Vehicle CreateVehicle(string make, string model, int year)
        {
            return new Truck { Make = make, Model = model, Year = year };
        }
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Car:");
            VehicleFactory factory = new CarFactory();
            factory.ManufactureVehicle("Toyota", "Camry", 2023);

            Console.WriteLine("- Truck:");
            factory = new TruckFactory();
            factory.ManufactureVehicle("Ford", "F-150", 2022);

        }
    }
}
