using Microsoft.Extensions.DependencyInjection;
using Agents.VictorInsurance.BuildingBlocks.Model.Swagger;

namespace Agents.VictorInsurance.BuildingBlocks.Bootstrapper.SwaggerRegistration
{
    public class SwaggerRegistration
    {
        public static void RegisterSwaggerServices(IServiceCollection serviceCollection,
                                                SwaggerDetails swaggerDetails)
        {
            serviceCollection.AddSwaggerGen(config => {
                config.SwaggerDoc(swaggerDetails.Version, new Microsoft.OpenApi.Models.OpenApiInfo()
                {
                    Title = swaggerDetails.ApiName,
                    Version = swaggerDetails.Version,
                    Description = swaggerDetails.Description 
                });
            });
        }
    }
}