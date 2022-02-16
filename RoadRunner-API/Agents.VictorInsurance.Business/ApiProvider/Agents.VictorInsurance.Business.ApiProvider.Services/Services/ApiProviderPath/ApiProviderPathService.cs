using System.Linq;
using System.Collections;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderPath;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using System;
using Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderPath;

namespace Agents.VictorInsurance.Business.ApiProvider.Services.Services.ApiProviderPath
{
    public class ApiProviderPathService :IApiProviderPathService
    {

        private readonly IMapper _mapper;
        public ApiProviderPathService(
                                IMapper mapper)
        {
            _mapper=mapper;
        }    


        public static List<DomainModel.ApiProviderPath> path = new List<DomainModel.ApiProviderPath>
{
        new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "API Keys",
            api_path_value = "https://api.briza-sandbox.io/api/v2/api-keys", method = "Post", 
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"
            },
            
        
        
new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Delete API Keys",
            api_path_value = "https://api.briza-sandbox.io/api/v2/api-keys/{apiKeyId}", method = "Delete",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
             
        
        
new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
            new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Delete API Keys",
            api_path_value = "https://api.briza-sandbox.io/api/v2/api-keys/{apiKeyId}", method = "Delete", 
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
            
        
        
        new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           new DomainModel.ApiProviderPath()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name="Briza",api_path_code = "Quotes",
            api_path_value = "https://api.briza-sandbox.io/api/v2/quotes", method = "Post",
            request_body = "{\"applicationId\": \"950273df-3a3c-4f01-b880-e5e454aff5d3\",\"productTypeId\": [\"f78b3ce3-7845-4a6e-b69f-f7d6e5c87b5b\"]}"},
           
       
       
};
        

             public IList<DomainModel.ApiProviderPath> GetPath(DomainModel.ApiProviderPathSearchModel pathSearchModel){
               IEnumerable<DomainModel.ApiProviderPath> result = path;
              
              
              return result?.ToList();
        }
    }
}