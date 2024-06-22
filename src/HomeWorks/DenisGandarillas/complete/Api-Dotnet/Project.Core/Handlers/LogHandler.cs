using Microsoft.Extensions.Logging;

public class LogHandler
{
    private readonly ILogger _logger;
    private static LogHandler instance;

    public static LogHandler Instance => instance ?? (instance = new LogHandler());

    private LogHandler()
    {
        ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.AddDebug();  
        });

        _logger = loggerFactory.CreateLogger<LogHandler>();
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
