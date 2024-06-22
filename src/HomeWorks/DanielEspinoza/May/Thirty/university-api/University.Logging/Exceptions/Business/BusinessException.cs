namespace University.Logging;
    public class BusinessException : AbstractException
    {
        private readonly LogHandler _logHandler;

        public BusinessException(string message, LogHandler logHandler)
            : base(message, Severity.WARNING)
        {
            _logHandler = logHandler;
        }

        public override void LogMessage()
        {
            _logHandler.Log(Severity, FriendlyMessage);
        }
    }
