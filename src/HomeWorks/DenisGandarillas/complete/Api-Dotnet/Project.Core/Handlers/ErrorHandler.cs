using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

public class ErrorHandler : IActionFilter
{
    private readonly ILogger<ErrorHandler> _logger;

    public ErrorHandler(ILogger<ErrorHandler> logger)
    {
        _logger = logger;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
        if (context.Exception == null)
        {
            return;
        }

        var exception = (context.Exception is AbstractException)
            ? context.Exception as AbstractException
            : new CriticalException(context.Exception);

        exception?.LogMessage();

        _logger.LogError(exception, exception.FriedlyMessage);

        context.Result = new ObjectResult(exception)
        {
            Value = exception?.FriedlyMessage
        };
        context.ExceptionHandled = true;
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
    }
}