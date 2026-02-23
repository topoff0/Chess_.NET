using Account.Application.Features.Auth.Commands.Login;
using FluentValidation;

namespace Account.Application.Features.Auth.Validation;

public class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("Email field must not be empty")
            .EmailAddress()
            .WithMessage("Incorrect email address")
            .MaximumLength(256)
            .WithMessage("Length must be less than 256");

        RuleFor(x => x.Password)
            .NotEmpty()
            .WithMessage("Password field must not be empty")
            .MinimumLength(8)
            .WithMessage("Password length must be at least 8 characters");
    }
}
