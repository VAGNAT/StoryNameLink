using Domain.Entities.ModelEF.Interfaces;
using Infrastructure.RepositoriesImplementation;
using Services;
using Services.Interfaces;
using Infrastructure.EF;
using AutoMapper;
using Services.Helpers.Mapping;
using StoryNameLink.Helpers.Mapping;

namespace StoryNameLink.Helpers
{
    /// <summary>
    /// Service registrar
    /// </summary>
    public static class Registrar
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {            
            return services.AddSingleton((IConfigurationRoot)configuration)
                .InstallServices()
                .ConfigureContext(configuration.GetValue<string>("ConnectionString")!)
                .InstallRepositories();
        }

        private static IServiceCollection InstallServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
            .AddTransient<IStoryService, StoryService>()
            .AddSingleton<IMapper>(new Mapper(GetMapperConfiguration()));                
            return serviceCollection;
        }

        private static IServiceCollection InstallRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddTransient<IStoryRepository, StoryRepository>();                
            return serviceCollection;
        }

        private static MapperConfiguration GetMapperConfiguration()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ChipUiMappingsProfile>();
                cfg.AddProfile<StoryUiMappingsProfile>();
                cfg.AddProfile<StoryMappingsProfile>();
            });
            configuration.AssertConfigurationIsValid();
            return configuration;
        }
    }
}
