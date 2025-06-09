using Microsoft.EntityFrameworkCore;
using Walkiria.Restrictions.DataContext;
using Walkiria.Restrictions.Interfaces;
using Walkiria.Restrictions.Services;

namespace Walkiria.Restricitons.Web.Startups;

public static class StartupExtensions
{
    public static IServiceCollection ConfigureService(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddControllers();

        services.AddScoped<IRestrictionsService, RestrictionsService>();

        services.AddDbContext<RestrictionDataContext>(x => x.UseMongoDB("connection", "dbName"));

        return services;
    }
}