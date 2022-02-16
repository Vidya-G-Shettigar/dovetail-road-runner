using Agents.VictorInsurance.Business.Policy.Infrastructure.Mapper;
using Microsoft.Extensions.DependencyInjection;

namespace Agents.VictorInsurance.Business.Policy.Infrastructure.Bootstrapper
{
    public class MapperRegistration
    {
        public static void RegisterMapperProfiles(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile(new MapperProfiles()));
        }
    }
}