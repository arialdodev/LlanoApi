using LlanoApp.Infrastructure.Configurations;
using LlanoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace LlanoApp.Infrastructure
{
    public static class InjectionDbContext 
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<DatabaseOptions>(configuration.GetSection("ConnectionStrings"));

            services.AddDbContext<LlanoAppDbContext>((serviceProvider, options) =>
            {
                var databaseOptions = serviceProvider.GetRequiredService<IOptions<DatabaseOptions>>().Value;
                options.UseSqlServer(databaseOptions.DbConnection);
            });

            return services;
        }
    }

}
