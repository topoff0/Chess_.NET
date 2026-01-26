using Account.Application.DTOs.Results.Common;
using MediatR;

namespace Account.Application.Features.Auth.Commands.EmailRegistration;

public record ConfirmEmailCommand(string Email, string VerificationCode)
    : IRequest<ResultT<Unit>>;

public sealed class ConfirmEmailCommandHandler : IRequestHandler<ConfirmEmailCommand, ResultT<Unit>>
{
    public Task<ResultT<Unit>> Handle(ConfirmEmailCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
