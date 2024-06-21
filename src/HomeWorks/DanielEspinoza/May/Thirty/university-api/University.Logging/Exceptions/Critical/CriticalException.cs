namespace University.Logging.Handlers;
public class CriticalException : AbstractException
{
    public CriticalException(Exception exception) 
    : base(exception, "Something wrong happened. Please contact your system administrator", Severity.ERROR)
    {
    }

    public override void LogMessage()
    {
        var current = InnerException;
        do
        {
           LogHandler.Instance.Log(Severity, current.Message);
           LogHandler.Instance.Log(Severity, current.StackTrace);
           current = current.InnerException; 
        } while (current != null);
    }
}