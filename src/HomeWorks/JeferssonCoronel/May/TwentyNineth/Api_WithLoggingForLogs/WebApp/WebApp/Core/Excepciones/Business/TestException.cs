using WebApp.Core.Handler;

namespace WebApp.Core.Excepciones.Business
{
    public class TestException : BusinessException
    {
        public TestException(LogHandler logHandler) : base("This is a test exception", logHandler)
        {
        }
    }
}