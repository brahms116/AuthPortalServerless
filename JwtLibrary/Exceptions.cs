using System.Runtime.Serialization;

namespace JwtLibrary;


public class InvalidSignatureException : Exception
{
    public InvalidSignatureException()
    {
    }

    public InvalidSignatureException(string? message) : base(message)
    {
    }

    public InvalidSignatureException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected InvalidSignatureException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}


public class ExpiredException : Exception
{
    public ExpiredException()
    {
    }

    public ExpiredException(string? message) : base(message)
    {
    }

    public ExpiredException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected ExpiredException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
