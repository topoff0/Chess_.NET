using Account.Application.DTOs.Results.Common;

namespace Account.Application.Common.Interfaces;

public interface IEmailSenderService
{
    Task<Result> SendEmailAsync(string email, string subject, string message, CancellationToken token);
}
