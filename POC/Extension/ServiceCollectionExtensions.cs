using Microsoft.Extensions.DependencyInjection;
using POC.Interfaces;
using POC.Service.Implementation;

namespace POC.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<IPocService, PocService>();

            return services;
        }
    }
}
