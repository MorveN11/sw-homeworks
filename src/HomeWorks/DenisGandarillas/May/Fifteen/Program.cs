namespace Fifteen
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Progression progression = new Progression(20);
            foreach (var item in progression)
            {
                Console.WriteLine(item);
            }
        }

    }

}
