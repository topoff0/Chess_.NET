using Account.API.Filters;

namespace Account.API.Extensions;

public static class AddFiltersExtension
{
    public static IServiceCollection AddControllersWithFilters(this IServiceCollection services)
    {
        services.AddControllers(options =>
        {
            options.Filters.Add<ValidateModelAttribute>();
        });

        return services;
    }
}
