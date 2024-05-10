using System;

public class Request
{
    public string Content { get; set; }
    public int Level { get; set; }

    public Request(string content, int level)
    {
        Content = content;
        Level = level;
    }
}

public interface IHandler
{
    void HandleRequest(Request request);
    void SetNextHandler(IHandler handler);
}

public abstract class BaseHandler : IHandler
{
    private IHandler _nextHandler;

    public void SetNextHandler(IHandler handler)
    {
        _nextHandler = handler;
    }

    public void HandleRequest(Request request)
    {
        if (CanHandle(request))
        {
            ProcessRequest(request);
        }
        else if (_nextHandler != null)
        {
            _nextHandler.HandleRequest(request);
        }
        else
        {
            Console.WriteLine("Ningún manejador puede manejar la solicitud.");
        }
    }

    protected abstract bool CanHandle(Request request);
    protected abstract void ProcessRequest(Request request);
}

public class EmployeeHandler : BaseHandler
{
    protected override bool CanHandle(Request request)
    {
        return request.Level <= 1; 
    }

    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine($"La solicitud '{request.Content}' ha sido aprobada por el empleado.");
    }
}

public class ManagerHandler : BaseHandler
{
    protected override bool CanHandle(Request request)
    {
        return request.Level <= 2; 
    }

    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine($"La solicitud '{request.Content}' ha sido aprobada por el gerente.");
    }
}


public class DirectorHandler : BaseHandler
{
    protected override bool CanHandle(Request request)
    {
        return request.Level <= 3; 
    }

    protected override void ProcessRequest(Request request)
    {
        Console.WriteLine($"La solicitud '{request.Content}' ha sido aprobada por el director.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var employeeHandler = new EmployeeHandler();
        var managerHandler = new ManagerHandler();
        var directorHandler = new DirectorHandler();

        employeeHandler.SetNextHandler(managerHandler);
        managerHandler.SetNextHandler(directorHandler);

        var request1 = new Request("Compra de suministros", 1);
        var request2 = new Request("Aprobación de presupuesto", 2);
        var request3 = new Request("Contratación de personal", 3);

        employeeHandler.HandleRequest(request1);
        employeeHandler.HandleRequest(request2);
        employeeHandler.HandleRequest(request3);
    }
}
