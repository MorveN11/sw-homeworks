namespace Seventen
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("FIBONAZI");
            using(var progression = new FibonaziProgression(20))
            {
                foreach (var item in progression)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }

}
