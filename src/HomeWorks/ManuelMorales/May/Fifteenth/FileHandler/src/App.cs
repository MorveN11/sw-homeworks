namespace Fifteenth.FileHandler;

class FileHandler : IDisposable
{
    private readonly string _root;
    private StreamReader? _reader;

    public FileHandler(string root)
    {
        _root = root;
    }

    public IList<string> Read()
    {
        var lines = new List<string>();

        using (_reader = new StreamReader(_root))
        {
            string? line;
            while ((line = _reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        return lines;
    }

    public void Dispose()
    {
        if (_reader != null)
        {
            _reader?.Dispose();
            _reader = null;
        }
    }
}

class App
{
    static void PrintDocument(string root)
    {
        using (var handler = new FileHandler(root))
        {
            var lines = handler.Read();

            foreach (var item in lines)
            {
                Console.WriteLine(item);
            }
        }
    }

    static void Main()
    {
        var root = "/home/fundacion/desarrollo/sw-homeworks/text.txt";
        PrintDocument(root);

        Console.ReadKey();
    }
}
