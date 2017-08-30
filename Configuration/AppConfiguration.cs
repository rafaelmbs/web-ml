using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using web_ml.Repository.Mapping;
using web_ml.Repository.Repositories;
using web_ml.Services;
using web_ml.Settings;

namespace web_ml.Configuration
{
    public class AppConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
        {
            //Automapper
            Mapper.Initialize(cfg =>
            {
                cfg.AllowNullCollections = true;
                cfg.AllowNullDestinationValues = true;
                cfg.CreateMissingTypeMaps = true;
                cfg.EnableNullPropagationForQueryMapping = true;

                cfg.AddProfile(new ItemsMapping());
                cfg.AddProfile(new ItemDetailMapping());
                cfg.AddProfiles(Assembly.GetEntryAssembly());
            });

            services.AddSingleton(Mapper.Instance);

            //AppSettings
            services.Configure<AppSettings>(configuration);

            //Services
            services.AddTransient<ItemsService>();

            //Repositories
            services.AddTransient<IItemsRepository, ItemsRepository>();
        }
    }
}
