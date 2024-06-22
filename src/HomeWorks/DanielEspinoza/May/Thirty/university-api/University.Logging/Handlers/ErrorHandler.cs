using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace  University.Logging;

    public class ErrorHandler : IActionFilter
    {
        private readonly ILogger<ErrorHandler> _logger;
        private readonly LogHandler _logHandler;

        public ErrorHandler(ILogger<ErrorHandler> logger, LogHandler logHandler)
        {
            _logger = logger;
            _logHandler = logHandler;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context == null)
            {
                return;
            }

            if (context.Exception != null)
            {
                var exception = (context.Exception is AbstractException)
                    ? context.Exception as AbstractException
                    : new CriticalException(context.Exception, _logHandler);

                exception?.LogMessage();

                context.Result = new ObjectResult(exception)
                {
                    Value = exception?.FriendlyMessage
                };
                context.ExceptionHandled = true;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
