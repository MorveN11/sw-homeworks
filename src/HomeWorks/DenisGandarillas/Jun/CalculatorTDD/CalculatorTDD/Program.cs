namespace CalculatorTDD
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("CONVERTER =================================================");
            var converter = new Converter();

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Input: 2 + 3");
            string operation = "2+3";
            var convertedOperation = converter.OperationConverter(operation);
            string result = converter.ToString(convertedOperation);
            Console.WriteLine("Output: " + result);

            Console.WriteLine("-----------------------------------------------------------");
        }

    }
}
