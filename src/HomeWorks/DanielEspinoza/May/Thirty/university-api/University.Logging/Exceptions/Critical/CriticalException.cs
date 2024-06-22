namespace  University.Logging;
public class CriticalException : AbstractException
{
       private readonly LogHandler _logHandler;

        public CriticalException(Exception exception, LogHandler logHandler) :
            base(exception, "Something wrong happened. Please contact to our system administratoraaaaa", Severity.ERROR)
        {
            _logHandler = logHandler;
        }

        public override void LogMessage()
        {
            var current = InnerException;
            do
            {
                if (current == null)
                {
                    continue;
                }
                _logHandler.Log(Severity, current.Message);
                current = current.InnerException;
            } while (current != null);
        }
}
