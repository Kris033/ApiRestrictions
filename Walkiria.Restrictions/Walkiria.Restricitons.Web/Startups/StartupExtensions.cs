using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Walkiria.Restricitons.Web.Options;
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
        services.AddCors(policy => policy.AddPolicy("default", opt =>
        {
            opt.AllowAnyHeader();
            opt.AllowCredentials();
            opt.AllowAnyMethod();
            opt.SetIsOriginAllowed(_ => true);
        }));
        services.AddControllers();
        services.AddSwaggerGen();
        /*
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new()
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(builder.Configuration
                    .GetSection("Jwt")
                    .GetSection("SecretKey").Value!))
            };
        });
        services.AddAuthorization(options =>
        {
            options.AddPolicy(nameof(User), policy =>
            {
                policy.RequireClaim(nameof(User.Id));
                policy.RequireClaim(nameof(User.TelegramId));
            });
        });
        builder.Services.AddSwaggerGen(option =>
        {
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
            {
                In = ParameterLocation.Header,
                Description = "Введите существующий токен",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement()
            {
                {
                    new OpenApiSecurityScheme()
                    {
                        Reference = new OpenApiReference()
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    }, []
                }
            });
        });
        */
        services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));

        services.AddControllers();

        services.AddScoped<IRestrictionsService, RestrictionsService>();

        services.AddDbContext<RestrictionDataContext>(x => x.UseNpgsql(configuration.GetConnectionString(nameof(RestrictionDataContext))));

        return services;
    }
}