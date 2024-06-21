namespace University.Logging.Handlers;
public class BusinessException : AbstractException
{
    public BusinessException(string message) : base(message, Severity.WARNING)
    {
    }

    public override void LogMessage()
    {
        LogHandler.Instance.Log(Severity, FriedlyMessage);
    }
}