namespace HomeWorks.ManuelMorales.May.Fourth.TemplateMethod
{
    public class CommaSeparatedValuesApp
    {
        public static void Main(string[] args)
        {
            CommaSeparatedValuesTemplate orderedCsv = new OrderCommaSeparatedValues(
                "10,243,51,2,4,2,5,6,3,2"
            );
            CommaSeparatedValuesTemplate reverseOrderedCsv = new ReverseOrderCommaSeparatedValues(
                "4,2,3,56,1,23,56,3,1,3"
            );

            Console.WriteLine(orderedCsv.GetStr());
            Console.WriteLine(reverseOrderedCsv.GetStr());
        }
    }
}
