namespace _titiritero
{

    public class Program
    {

        public static void Main()
        {

            var puppet = new Puppet();
            var puppeteer = new Puppeteer();
            puppeteer.SetPuppet(puppet);

            puppeteer.HandlePuppet();

        }

    }

}
