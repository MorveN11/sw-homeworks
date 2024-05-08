public class App
{
    public static void Main(string[] args)
    {
        var firstCsv = "10,243,51,2,4,2,5,6,3,2";
        var orderedCsv = new OrderCommaSeparatedValues(firstCsv);

        var secondCsv = "4,2,3,56,1,23,56,3,1,3";
        var reverseOrderedCsv = new ReverseOrderCommaSeparatedValues(secondCsv);

        Console.WriteLine("Original first CSV:");
        Console.WriteLine(firstCsv);
        Console.WriteLine("Ordered first CSV:");
        Console.WriteLine(orderedCsv.Csv);

        Console.WriteLine("Original second CSV:");
        Console.WriteLine(secondCsv);
        Console.WriteLine("Reverse ordered second CSV:");
        Console.WriteLine(reverseOrderedCsv.Csv);
    }
}
