using Microsoft.Extensions.Logging;

namespace WebApp.Core.Handler
{
    public class LogHandler
    {
        private readonly ILogger<LogHandler> _logger;

        public LogHandler(ILogger<LogHandler> logger)
        {
            _logger = logger;
        }

        public void Log(Severity severity, string message)
        {
            switch (severity)
            {
                case Severity.DEBUG:
                    _logger.LogDebug(message);
                    break;
                case Severity.INFO:
                    _logger.LogInformation(message);
                    break;
                case Severity.WARNING:
                    _logger.LogWarning(message);
                    break;
                case Severity.ERROR:
                    _logger.LogError(message);
                    break;
                case Severity.FATAL:
                    _logger.LogCritical(message);
                    break;
            }
        }
    }
}