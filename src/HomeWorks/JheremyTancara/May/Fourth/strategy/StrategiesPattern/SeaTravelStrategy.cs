/// <summary>
/// Clase que representa la estrategia de viaje marítimo.
/// </summary>
public class SeaTravelStrategy : TravelStrategy {
    /// <summary>
    /// Calcula el costo de un viaje marítimo.
    /// </summary>
    /// <param name="distance">La distancia del viaje en kilómetros.</param>
    /// <param name="passengers">El número de pasajeros que viajarán.</param>
    /// <returns>El costo total del viaje marítimo.</returns>
    public double CalculateCost(double distance, int passengers) {
        double baseCost = distance * 0.25;
        double passengerCost = passengers * 50;
        return baseCost + passengerCost;
    }
}
