using Microsoft.Extensions.DependencyInjection;
using Agents.VictorInsurance.Business.Proposal.Services.Interfaces;
using Agents.VictorInsurance.Business.Proposal.Services.Services;
namespace Agents.VictorInsurance.Business.Proposal.Services.Bootstrapper
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProposalService, ProposalService>();
        }
    }
}