
using Account.Application.Common.Errors;

namespace Account.Application.Exceptions;

public class CustomValidationException : Exception
{
    public Error Error { get; }
    public CustomValidationException(string message, Error error)
        : base(message)
    {
        Error = error;
    }

    public CustomValidationException(Error error)
        : base(error.Code)
    {
        Error = error;
    }
}
