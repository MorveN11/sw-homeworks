namespace University.Logging.Handlers;

public class TestException: BusinessException
{
    public TestException(): base("This is a test exception")
    {
    }
}