using Microsoft.Extensions.DependencyInjection;
using Agents.VictorInsurance.Business.Policy.Services.Interfaces;
using Agents.VictorInsurance.Business.Policy.Services.Services;
namespace Agents.VictorInsurance.Business.Policy.Services.Boostrapper
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPolicyService, PolicyService>();
        }
    }
}