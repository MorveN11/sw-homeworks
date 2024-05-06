/// <summary>
/// Calculador de viajes que utiliza una estrategia de viaje para calcular el costo de un viaje.
/// </summary>
public class TravelCalculator {
    // Campo privado que almacena la estrategia actual de viaje
    private TravelStrategy strategy;

    /// <summary>
    /// Constructor de TravelCalculator que inicializa con una estrategia de viaje dada.
    /// </summary>
    /// <param name="initialStrategy">La estrategia de viaje inicial que se utilizará para calcular los costos.</param>
    public TravelCalculator(TravelStrategy initialStrategy) {
        strategy = initialStrategy;
    }

    /// <summary>
    /// Establece una nueva estrategia de viaje.
    /// </summary>
    /// <param name="newStrategy">La nueva estrategia de viaje a utilizar.</param>
    public void SetStrategy(TravelStrategy newStrategy) {
        strategy = newStrategy;
    }

    /// <summary>
    /// Calcula el costo de un viaje utilizando la estrategia de viaje actual.
    /// </summary>
    /// <param name="distance">La distancia del viaje en kilómetros.</param>
    /// <param name="passengers">El número de pasajeros que viajarán.</param>
    /// <returns>El costo total del viaje según la estrategia actual.</returns>
    public double CalculateCost(double distance, int passengers) {
        return strategy.CalculateCost(distance, passengers);
    }
}
