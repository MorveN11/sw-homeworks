public abstract class AbstractException : Exception
{
    public new Exception InnerException { get; protected set; }
    public string FriedlyMessage { get; protected set; }
    public Severity Severity { get; protected set; }

    public AbstractException(string friendlyMessage, Severity severity)
    {
        FriedlyMessage = friendlyMessage;
        Severity = severity;
    }

    public AbstractException(Exception exception, string friendlyMessage, Severity severity) : this(friendlyMessage, severity)
    {
        InnerException = exception;
    }
    public abstract void LogMessage();
}
