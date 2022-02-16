using Agents.VictorInsurance.Business.Quote.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Agents.VictorInsurance.Business.Quote.Services.Services;

namespace Agents.VictorInsurance.Business.Quote.Services.Bootstrapper
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IQuoteService, QuoteService>();
        }
    }
}