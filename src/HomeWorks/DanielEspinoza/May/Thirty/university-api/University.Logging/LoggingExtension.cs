
using Microsoft.Extensions.DependencyInjection;

namespace University.Logging;

public static class LoggingExtension
{
    public static void AddLoggingCore(this IServiceCollection services)
    {
        services.AddSingleton<LogHandler>();
   }
}
