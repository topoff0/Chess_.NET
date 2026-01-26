using Account.Application.DTOs.Results.Common;

namespace Account.Application.Common.Interfaces;

public interface IEmailServiceSender
{
    Task<Result> SendVerificationCodeAsync(string email, string verificationCode, CancellationToken token);
}
