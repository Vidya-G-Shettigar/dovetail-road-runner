using Microsoft.Extensions.DependencyInjection;
using Agents.VictorInsurance.Business.Documents.Services.Services.Carrier;
using Agents.VictorInsurance.Business.Documents.Services.Interfaces.Carrier;
using Agents.VictorInsurance.Business.Documents.Services.Interfaces.BusinessLine;
using Agents.VictorInsurance.Business.Documents.Services.Services.BusinessLine;

namespace Agents.VictorInsurance.Business.Documents.Services.Bootstrapper
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<ICarrierDocumentService, CarrierDocumentService>();
            serviceCollection.AddScoped<IBusinessLineDocumentService, BusinessLineDocumentService>();

        }
    }
}