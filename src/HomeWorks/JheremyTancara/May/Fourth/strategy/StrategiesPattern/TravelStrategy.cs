/// <summary>
/// Interfaz que define la estrategia de viaje para calcular el costo de un viaje.
/// </summary>
public interface TravelStrategy {
    /// <summary>
    /// Calcula el costo de un viaje según la distancia y el número de pasajeros.
    /// </summary>
    /// <param name="distance">La distancia del viaje en kilómetros.</param>
    /// <param name="passengers">El número de pasajeros que viajarán.</param>
    /// <returns>El costo total del viaje.</returns>
    double CalculateCost(double distance, int passengers);
}
