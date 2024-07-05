namespace CalculatorTDD
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("CONVERTER =================================================");
            var converter = new Converter();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Input: 2 + 3 * 12");
            string operation = "2 + 3 - 12";
            var convertedOperation = converter.GetOperators(operation);
            string a = converter.GetDigits(operation);
            Console.WriteLine("Output: " + convertedOperation + " | " + a);

            Console.WriteLine("-----------------------------------------------------------");
        }

    }
}
