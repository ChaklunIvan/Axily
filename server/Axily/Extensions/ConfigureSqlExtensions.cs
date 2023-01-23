using Axily.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Axily.Extensions
{
    public static class ConfigureSqlExtensions
    {
        public static IServiceCollection ConfigureNpgsqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opts =>
            opts.UseLazyLoadingProxies().UseNpgsql(configuration.GetConnectionString("PostgreConnection")));
            return services;
        }
    }
}
