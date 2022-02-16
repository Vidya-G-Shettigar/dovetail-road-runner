using Microsoft.Extensions.DependencyInjection;

namespace Agents.VictorInsurance.Business.Proposal.Infrastructure.Bootstrapper
{
    public class MapperRegistration
    {
        public static void RegisterMapperProfiles(IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(cfg => cfg.AddProfile(new Mapper.MapperProfile()));
        }
    }
}