namespace Calculator.Exceptions;

[Serializable]
public class InvalidExpressionException : Exception
{
    public InvalidExpressionException()
    {
    }


    public InvalidExpressionException(string? message) : base(message)
    {
    }

    public InvalidExpressionException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
