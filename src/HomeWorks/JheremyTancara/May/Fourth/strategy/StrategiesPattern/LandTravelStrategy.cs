/// <summary>
/// Clase que representa la estrategia de viaje terrestre.
/// </summary>
public class LandTravelStrategy : TravelStrategy {
    /// <summary>
    /// Calcula el costo de un viaje terrestre.
    /// </summary>
    /// <param name="distance">La distancia del viaje en kilómetros.</param>
    /// <param name="passengers">El número de pasajeros que viajarán.</param>
    /// <returns>El costo total del viaje terrestre.</returns>
    public double CalculateCost(double distance, int passengers) {
        double baseCost = distance * 0.15;
        double passengerCost = passengers * 10;
        return baseCost + passengerCost;
    }
}
