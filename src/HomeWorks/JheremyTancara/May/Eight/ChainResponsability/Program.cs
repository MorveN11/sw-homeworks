public interface IHandler
{
    IHandler SetNext(IHandler handler);
    object Handle(object request);
}

public abstract class BaseHandler : IHandler
{
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public virtual object Handle(object request)
    {
        if (_nextHandler != null)
        {
            return _nextHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}

public class ConcreteHandler1 : BaseHandler
{
    public override object Handle(object request)
    {
        if (request.ToString() == "1")
        {
            return $"ConcreteHandler1: Manejé la solicitud '{request}'.";
        }
        else
        {
            return base.Handle(request);
        }
    }
}

public class ConcreteHandler2 : BaseHandler
{
    public override object Handle(object request)
    {
        if (request.ToString() == "2")
        {
            return $"ConcreteHandler2: Manejé la solicitud '{request}'.";
        }
        else
        {
            return base.Handle(request);
        }
    }
}

public class Client
{
    public void Main()
    {
        var handler1 = new ConcreteHandler1();
        var handler2 = new ConcreteHandler2();
        handler1.SetNext(handler2);

        Console.WriteLine(handler1.Handle("1")); // ConcreteHandler1 manejará la solicitud '1'.
        Console.WriteLine(handler1.Handle("2")); // ConcreteHandler2 manejará la solicitud '2'.
        Console.WriteLine(handler1.Handle("3")); // Ningún manejador pudo procesar la solicitud.
    }
}

class Program
{
    static void Main(string[] args)
    {
        var client = new Client();
        client.Main();
    }
}
