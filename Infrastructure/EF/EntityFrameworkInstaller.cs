using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF
{
    /// <summary>
    /// Configure Data base
    /// </summary>
    public static class EntityFrameworkInstaller
    {
        public static IServiceCollection ConfigureContext(this IServiceCollection services,
            string connectionString)
        {
            services.AddDbContext<StoryNameLinkContext>(optionsBuilder
                => optionsBuilder                    
                    .UseSqlServer(connectionString, opt=>opt.MigrationsAssembly("Infrastructure")));                    

            services.AddHealthChecks()
                .AddDbContextCheck<StoryNameLinkContext>();

            return services;
        }
    }
}
