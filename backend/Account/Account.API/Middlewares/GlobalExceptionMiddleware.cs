using System.Net;
using Account.Application.Common.Errors;

namespace Account.API.Middlewares;

public sealed class GlobalExceptionMiddleware(RequestDelegate next,
                                              ILogger<GlobalExceptionMiddleware> logger)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger<GlobalExceptionMiddleware> _logger = logger;

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
        }
    }


    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        _logger.LogCritical(exception, "Unexpected exception occurred");

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

        var error = Error.Failure(
            ErrorCodes.InternalError,
            ErrorMessages.InternalError
        );

        await context.Response.WriteAsJsonAsync(error);
    }
}
