using Account.Application.Common.Results;
using Account.Application.DTOs;

namespace Account.Application.Common.Interfaces;

public interface IEmailSenderService
{
    Task<Result> SendEmailAsync(SendEmailDto dto, CancellationToken token = default);
}
