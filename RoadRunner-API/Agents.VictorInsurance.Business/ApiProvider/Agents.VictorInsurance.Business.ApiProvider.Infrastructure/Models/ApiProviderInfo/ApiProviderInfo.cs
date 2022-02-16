using System;
namespace Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderInfo
{
    public class ApiProviderInfo:ApiProviderSearchModel
    {

         public string api_provider_name { get; set; }

         public string status { get; set; }
    }
}