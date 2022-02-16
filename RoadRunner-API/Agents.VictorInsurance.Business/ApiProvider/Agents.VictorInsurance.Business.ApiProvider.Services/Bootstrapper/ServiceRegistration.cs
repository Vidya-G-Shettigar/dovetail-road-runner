using Agents.VictorInsurance.Business.ApiProvider.Services.ApiProviderInfo;
using Agents.VictorInsurance.Business.ApiProvider.Services.ApiProviderKey;
using Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderInfo;
using Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderPath;
using Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderQuestions;
using Agents.VictorInsurance.Business.ApiProvider.Services.Services.ApiProviderPath;
using Agents.VictorInsurance.Business.Provider.Services.Interfaces.ApiProviderKey;
using Microsoft.Extensions.DependencyInjection;
using Agents.VictorInsurance.Business.ApiProvider.Services.Services.ApiProviderQuestion;

namespace Agents.VictorInsurance.Business.ApiProvider.Services.Bootstrapper
{
    public class ServiceRegistration
    {
        public static void RegisterServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IApiProviderInfoService,ApiProviderInfoService >();
            serviceCollection.AddScoped<IApiProviderKeyService,ApiProviderKeyService>();
            serviceCollection.AddScoped<IApiProviderPathService, ApiProviderPathService>();
            serviceCollection.AddScoped<IApiProviderQuestionService,ApiProviderQuestionService>();
        }
    }
}