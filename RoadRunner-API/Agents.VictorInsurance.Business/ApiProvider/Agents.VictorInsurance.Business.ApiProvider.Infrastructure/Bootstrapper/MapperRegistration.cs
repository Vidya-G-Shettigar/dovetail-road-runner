using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Agents.VictorInsurance.Business.ApiProvider.Infrastructure.MapperProfiles;
namespace Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Bootstrapper
{
    public class MapperRegistration
    {
        public static void RegisterMapperProfiles(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(cfg =>
                                  cfg.AddProfile(new MapperProfiles.MapperProfiles()));
        }
    }
}