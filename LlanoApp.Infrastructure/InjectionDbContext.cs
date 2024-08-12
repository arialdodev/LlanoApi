using LlanoApp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LlanoApp.Infrastructure
{
    public static class InjectionDbContext
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LlanoAppDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DbConnection")));

        
            return services;
        }
    }

}
