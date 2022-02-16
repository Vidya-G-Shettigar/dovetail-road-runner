using System;
namespace Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderKey
{
    public class ApiProviderKey :ApiProviderKeySearchModel
    {
      
         public string api_key { get; set; }

         public string api_key_value { get; set; }
    }
}