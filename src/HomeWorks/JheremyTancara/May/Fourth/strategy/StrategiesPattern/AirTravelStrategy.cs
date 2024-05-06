/// <summary>
/// Clase que representa la estrategia de viaje aéreo.
/// </summary>
public class AirTravelStrategy : TravelStrategy {
    /// <summary>
    /// Calcula el costo de un viaje aéreo.
    /// </summary>
    /// <param name="distance">La distancia del viaje en kilómetros.</param>
    /// <param name="passengers">El número de pasajeros que viajarán.</param>
    /// <returns>El costo total del viaje aéreo.</returns>
    public double CalculateCost(double distance, int passengers) {
        double baseCost = distance * 0.3;
        double passengerCost = passengers * 100;
        return baseCost + passengerCost;
    }
}
