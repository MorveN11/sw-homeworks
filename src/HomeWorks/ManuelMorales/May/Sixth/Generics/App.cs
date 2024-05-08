public class App
{
    public static void Main(string[] args)
    {
        var myNumberList = new MyList<int>();

        myNumberList.Add(1);
        myNumberList.Add(2);
        myNumberList.Add(3);
        myNumberList.RemoveAt(1);

        var myStringList = new MyList<string>();
        myStringList.Add("Hello");
        myStringList.Add("World");
        myStringList.Add("Generics");
        myStringList.Add("!");
        myStringList.RemoveAt(2);

        Console.WriteLine("MyList<int>: ");
        Console.WriteLine($"My List Count: {myNumberList.Count}");
        Console.WriteLine($"My List Items:\n{myNumberList}");

        Console.WriteLine("MyList<string>: ");
        Console.WriteLine($"My List Count: {myStringList.Count}");
        Console.WriteLine($"My List Items:\n{myStringList}");
    }
}
