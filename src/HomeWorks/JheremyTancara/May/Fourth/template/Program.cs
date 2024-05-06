class Program {
    static void Main(string[] args) {
        ReportGenerator salesReport = new SalesReportGenerator();
        ReportGenerator customerReport = new CustomerReportGenerator();
        ReportGenerator inventoryReport = new InventoryReportGenerator();

        Console.WriteLine("Generando informe de ventas:");
        salesReport.GenerateReport();
        Console.WriteLine();

        Console.WriteLine("Generando informe de clientes:");
        customerReport.GenerateReport();
        Console.WriteLine();

        Console.WriteLine("Generando informe de inventario:");
        inventoryReport.GenerateReport();
        Console.WriteLine();
    }
}
