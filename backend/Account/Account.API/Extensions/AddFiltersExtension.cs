using Microsoft.AspNetCore.Mvc;

namespace Account.API.Extensions;

public static class AddFiltersExtension
{
    public static IServiceCollection AddControllersWithFilters(this IServiceCollection services)
    {
        services.AddControllers();

        services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });

        return services;
    }
}
