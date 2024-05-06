/// <summary>
/// Clase abstracta que define el esqueleto para generar informes.
/// </summary>
public abstract class ReportGenerator {
    /// <summary>
    /// Genera el informe siguiendo un algoritmo de plantilla.
    /// </summary>
    public void GenerateReport() {
        InitializeReport();
        LoadData();
        FormatReport();
        ExportReport();
    }

    /// <summary>
    /// Inicializa el informe.
    /// Este método debe ser implementado por las subclases para establecer el estado inicial del informe.
    /// </summary>
    protected abstract void InitializeReport();

    /// <summary>
    /// Carga los datos necesarios para el informe.
    /// Este método debe ser implementado por las subclases para cargar los datos específicos para el informe.
    /// </summary>
    protected abstract void LoadData();

    /// <summary>
    /// Formatea el informe según los requisitos.
    /// Este método debe ser implementado por las subclases para formatear el informe de acuerdo con los requisitos específicos.
    /// </summary>
    protected abstract void FormatReport();

    /// <summary>
    /// Exporta el informe a un formato específico.
    /// Este método debe ser implementado por las subclases para exportar el informe a un formato específico.
    /// </summary>
    protected abstract void ExportReport();
}
