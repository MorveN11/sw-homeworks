/// <summary>
/// Clase que implementa la generación de informes de ventas.
/// </summary>
public class SalesReportGenerator : ReportGenerator {
    /// <summary>
    /// Inicializa el informe de ventas.
    /// </summary>
    protected override void InitializeReport() {
        Console.WriteLine("Inicializando informe de ventas...");
    }

    /// <summary>
    /// Carga los datos de ventas necesarios para el informe.
    /// </summary>
    protected override void LoadData() {
        Console.WriteLine("Cargando datos de ventas...");
    }

    /// <summary>
    /// Formatea el informe de ventas según los requisitos.
    /// </summary>
    protected override void FormatReport() {
        Console.WriteLine("Formateando informe de ventas...");
    }

    /// <summary>
    /// Exporta el informe de ventas a un archivo PDF.
    /// </summary>
    /// <returns>Un archivo PDF con los datos formateados de ventas.</returns>
    protected override void ExportReport() {
        Console.WriteLine("Exportando informe de ventas a PDF...");
    }
}
