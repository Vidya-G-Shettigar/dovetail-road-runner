using System;
namespace Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderPath
{ 
    public class ApiProviderPath :ApiProviderPathSearchModel
    
    {

        public string api_path_value { get; set; }
        public string method { get; set; }

        public string request_body { get; set; }

   }
}