using Account.Application.Common.Errors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Account.API.Filters;

public sealed class ValidateModelAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        if (context.ActionArguments.Values.Any(v => v == null))
        {
            var error = Error.Validation(
                ErrorCodes.ModelStateValidationFailed,
                ErrorMessages.ModelStateValidationFailed);

            context.Result = new BadRequestObjectResult(error);
        }

        if (!context.ModelState.IsValid)
        {
            var error = Error.Validation(
                ErrorCodes.ModelStateValidationFailed,
                ErrorMessages.ModelStateValidationFailed);

            context.Result = new BadRequestObjectResult(error);
        }
    }
}
