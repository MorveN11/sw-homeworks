public class King : IPuppet
{
    public King() { }

    public void Talk()
    {
        Console.WriteLine("I am a king.");
    }

    public void Act()
    {
        Console.WriteLine("I am a king acting.");
    }
}
