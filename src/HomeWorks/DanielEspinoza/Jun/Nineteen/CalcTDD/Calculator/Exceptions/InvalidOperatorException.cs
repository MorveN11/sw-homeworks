namespace Calculator.Exceptions;


[Serializable]
public class InvalidOperatorException : Exception
{
    public InvalidOperatorException()
    {
    }

    public InvalidOperatorException(string? message) : base(message)
    {
    }

    public InvalidOperatorException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}



