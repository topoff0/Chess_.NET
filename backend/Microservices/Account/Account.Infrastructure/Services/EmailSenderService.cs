using Account.Application.Common.Interfaces;
using Account.Application.DTOs.Results.Common;

namespace Account.Infrastructure.Services;

public class EmailSenderService : IEmailSenderService
{
    public Task<Result> SendEmailAsync(string email, string subject, string message, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}
