/// <summary>
/// Clase que implementa la generación de informes de clientes.
/// </summary>
public class CustomerReportGenerator : ReportGenerator {
    /// <summary>
    /// Inicializa el informe de clientes.
    /// </summary>
    protected override void InitializeReport() {
        Console.WriteLine("Inicializando informe de clientes...");
    }

    /// <summary>
    /// Carga los datos de clientes necesarios para el informe.
    /// </summary>
    protected override void LoadData() {
        Console.WriteLine("Cargando datos de clientes...");
    }

    /// <summary>
    /// Formatea el informe de clientes según los requisitos.
    /// </summary>
    protected override void FormatReport() {
        Console.WriteLine("Formateando informe de clientes...");
    }

    /// <summary>
    /// Exporta el informe de clientes a un archivo Excel.
    /// </summary>
    /// <returns>Un archivo Excel con los datos formateados de clientes.</returns>
    protected override void ExportReport() {
        Console.WriteLine("Exportando informe de clientes a Excel...");
    }
}
