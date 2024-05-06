/// <summary>
/// Clase que implementa la generación de informes de inventario.
/// </summary>
public class InventoryReportGenerator : ReportGenerator {
    /// <summary>
    /// Inicializa el informe de inventario.
    /// </summary>
    protected override void InitializeReport() {
        Console.WriteLine("Inicializando informe de inventario...");
    }

    /// <summary>
    /// Carga los datos de inventario necesarios para el informe.
    /// </summary>
    protected override void LoadData() {
        Console.WriteLine("Cargando datos de inventario...");
    }

    /// <summary>
    /// Formatea el informe de inventario según los requisitos.
    /// </summary>
    protected override void FormatReport() {
        Console.WriteLine("Formateando informe de inventario...");
    }

    /// <summary>
    /// Exporta el informe de inventario a un archivo CSV.
    /// </summary>
    /// <returns>Un archivo CSV con los datos formateados de inventario.</returns>
    protected override void ExportReport() {
        Console.WriteLine("Exportando informe de inventario a CSV...");
    }
}
