public class PuppetMaster<T>
    where T : IPuppet, new()
{
    public PuppetMaster() { }

    public void Perform(T puppet)
    {
        puppet.Talk();
        puppet.Act();
    }
}
