namespace Account.Application.Common.Errors;

public static class ErrorCodes
{
    // Auth errors
    public const string InvalidEmail = "auth.invalid_email";
    public const string UserNotFound = "auth.user_not_found";
    public const string VerificationCodeNotFound = "auth.verification_code_not_found";
    public const string IncorrectPassword = "auth.incorrect_password";
    public const string InvalidToken = "auth.invalid_token";
    public const string TokenExpired = "auth.token_expired";
    public const string AccountNotActivated = "auth.account_not_activated";

    // Validation errors
    public const string GeneralValidation = "validation.validation_error";
    // public const string ModelStateValidationFailed = "model_state_validation.failed";
    // public const string UsernameAlreadyExists = "validation.username_exists";

    // System errors
    public const string InternalError = "system.internal_error";
    public const string ServiceUnavailable = "system.service_unavailable";

    // Unexpected errors
    public const string StartEmailAuthUnexpectedError = "start_email_auth.unexpected_error";
}

public static class ErrorMessages
{
    // Auth messages
    public const string InvalidEmail = "Incorrect email format";
    public const string UserNotFound = "User is not found";
    public const string VerificationCodeNotFound = "We have not sent any verification codes to this email";
    public const string IncorrectPassword = "Password is not correct";
    public const string AccountNotActivated = "User is not activated";

    // Validation messages
    public const string ModelStateValidationFailed = "Invalid request data format";
    public const string UsernameAlreadyExists = "Username is already taken";

    // System messages
    public const string InternalError = "An unexpected error occurred";

    // Unexpected messages
    public const string UnexpectedError = "Something went wrong";
}
