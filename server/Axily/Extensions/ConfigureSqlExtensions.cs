using Axily.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Axily.Extensions
{
    public static class ConfigureSqlExtensions
    {
        public static IServiceCollection ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opts =>
            opts.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
