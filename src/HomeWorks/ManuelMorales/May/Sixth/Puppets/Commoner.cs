public class Commoner : IPuppet
{
    public Commoner() { }

    public void Talk()
    {
        Console.WriteLine("I am a commoner.");
    }

    public void Act()
    {
        Console.WriteLine("I am a commoner acting.");
    }
}
