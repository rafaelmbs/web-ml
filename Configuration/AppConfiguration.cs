using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using web_ml.Repository.Repositories;
using web_ml.Services;
using web_ml.Settings;

namespace web_ml.Configuration
{
    public class AppConfiguration
    {
        public static void ConfigureServices(IServiceCollection services, IConfigurationRoot configuration)
        {
            //AppSettings
            services.Configure<AppSettings>(configuration);

            //Services
            services.AddTransient<ItemsService>();    

            //Repositories
            services.AddTransient<IItemsRepository, ItemsRepository>();
        }
    }
}
