using Microsoft.Extensions.DependencyInjection;

namespace Agents.VictorInsurance.BuildingBlocks.Bootstrappper.CorsRegistration
{
    public class CorsRegistration
    {
        public static void RegisterDefaultCors(IServiceCollection serviceCollection)
        {
            serviceCollection.AddCors(config => {
                config.AddPolicy("Allow Origin", options => options.AllowAnyOrigin());
            });
        }

        public static void RegisterCorsWithOrigins(IServiceCollection serviceCollection,string uri)
        {
            serviceCollection.AddCors(config => {
                config.AddPolicy("Allow Origin", options => options.WithOrigins(uri));
            });
        }
    }
}