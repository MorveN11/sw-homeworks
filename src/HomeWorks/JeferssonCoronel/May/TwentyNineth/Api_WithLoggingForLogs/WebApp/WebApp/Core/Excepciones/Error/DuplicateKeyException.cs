using WebApp.Core.Handler;

namespace WebApp.Core.Excepciones.Error
{
    public class DuplicateKeyException : AbstractException
    {
        private readonly LogHandler _logHandler;

        public DuplicateKeyException(Exception exception, LogHandler logHandler)
            : base(exception, "A entity with the same ID already exists.", Severity.ERROR)
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