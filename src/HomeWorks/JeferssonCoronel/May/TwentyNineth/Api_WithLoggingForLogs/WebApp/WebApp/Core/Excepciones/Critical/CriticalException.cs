using WebApp.Core.Handler;

namespace WebApp.Core.Excepciones.Critical
{
    public class CriticalException : AbstractException
    {
        private readonly LogHandler _logHandler;

        public CriticalException(Exception exception, LogHandler logHandler) :
            base(exception, "Something wrong happened. Please contact to our system administrator", Severity.ERROR)
        {
            _logHandler = logHandler;
        }

        public override void LogMessage()
        {
            var current = InnerException;
            do
            {
                _logHandler.Log(Severity, current.Message);
                _logHandler.Log(Severity, current.StackTrace);
                current = current.InnerException;
            } while (current != null);
        }
    }
}