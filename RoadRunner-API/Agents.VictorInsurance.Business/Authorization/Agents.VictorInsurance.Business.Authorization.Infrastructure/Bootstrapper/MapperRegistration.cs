using Microsoft.Extensions.DependencyInjection;
using Agents.VictorInsurance.Business.Authorization.Infrastructure.MapperProfiles;
namespace Agents.VictorInsurance.Business.Authorization.Infrastructure.Bootstrapper
{
    public class MapperRegistration
    {
        public static void RegisterMapperProfiles(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(cfg =>   cfg.AddProfile(new MapperProfiles.MapperProfiles()));
        }   
    }
}