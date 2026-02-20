using Account.Application.Features.Auth.Commands.EmailAuthentication;
using FluentValidation;

namespace Account.Application.Features.Auth.Validation;

public class StartEmailAuthCommandValidator : AbstractValidator<StartEmailAuthCommand>
{
    public StartEmailAuthCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email must not be empty")
            .EmailAddress()
            .WithMessage("Incorrect email address")
            .MaximumLength(256)
            .WithMessage("Length must be less than 256");
    }
}
