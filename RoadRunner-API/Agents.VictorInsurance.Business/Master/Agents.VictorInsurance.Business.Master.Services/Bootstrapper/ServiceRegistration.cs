using Microsoft.Extensions.DependencyInjection;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.BusinessLine;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.Carrier;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.ClassCode;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.IndustryCode;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.LegalEntityType;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.State;
using Agents.VictorInsurance.Business.Master.Services.Services.BusinessLine;
using Agents.VictorInsurance.Business.Master.Services.Services.Carrier;
using Agents.VictorInsurance.Business.Master.Services.Services.ClassCode;
using Agents.VictorInsurance.Business.Master.Services.Services.IndustryCode;
using Agents.VictorInsurance.Business.Master.Services.Services.LegalEntityType;
using Agents.VictorInsurance.Business.Master.Services.Services.State;

namespace Agents.VictorInsurance.Business.Master.Services.Boostrapper
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStateService, StateService>();
            serviceCollection.AddScoped<IBusinessLineService, BusinessLineService>();
            serviceCollection.AddScoped<IClassCodeService, ClassCodeService>();
            serviceCollection.AddScoped<ILegalEntityTypeService,LegalEntityTypeService>();
            serviceCollection.AddScoped<ICarrierService, CarrierService>();
            serviceCollection.AddScoped<IIndustryCodeService, IndustryCodeService>();
        }
    }
}