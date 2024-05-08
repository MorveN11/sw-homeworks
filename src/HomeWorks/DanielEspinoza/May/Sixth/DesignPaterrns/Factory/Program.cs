namespace FileFactory{


public interface IDocument{
    void Open(string fileName);
    void Write(string text);
    void Close();
}

public class ExcelDocument : IDocument
{
    public void Open(string fileName){
        Console.WriteLine($"Opened Excel {fileName} Document");
    }

    public void Write(string text){
        Console.WriteLine("writing to Excel...");
    }

    public void Close(){
        Console.WriteLine("Closing Excel...");
    }
}

public class WordDocument : IDocument
{
    public  void Open(string fileName){
        Console.WriteLine($"Opened Word {fileName} Document");
    }

    public void Write(string text){
        Console.WriteLine("writing to Word...");
    }

    public void Close(){
        Console.WriteLine("Closing Word...");
    }
}

public interface IDocumentFactory
{
    IDocument CreateDocument();
}

public class ExcelDocumentFactory : IDocumentFactory
{
    public IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

public class WordDocumentFactory : IDocumentFactory
{
    public IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

public class FileManager
{
    public IDocument CreateDocument(IDocumentFactory factory)
    {
        return factory.CreateDocument();
    }
}

class MainApp
{
    static void Main()
    {
        FileManager fileManager = new FileManager();
        IDocument excelFile = fileManager.CreateDocument(new ExcelDocumentFactory());
        excelFile.Open("file.xlsx");

        IDocument wordFile = fileManager.CreateDocument(new WordDocumentFactory());
        wordFile.Open("file.docx");
    }
}
}
