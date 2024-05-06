class Program {
    static void Main(string[] args) {
        TravelCalculator calculator = new TravelCalculator(new AirTravelStrategy());

        double cost = calculator.CalculateCost(1000, 2);
        Console.WriteLine($"Costo de viaje aéreo para 2 pasajeros en 1000 km: {cost}");

        calculator.SetStrategy(new LandTravelStrategy());
        cost = calculator.CalculateCost(1000, 2);
        Console.WriteLine($"Costo de viaje terrestre para 2 pasajeros en 1000 km: {cost}");

        calculator.SetStrategy(new SeaTravelStrategy());
        cost = calculator.CalculateCost(1000, 2);
        Console.WriteLine($"Costo de viaje marítimo para 2 pasajeros en 1000 km: {cost}");
    }
}
