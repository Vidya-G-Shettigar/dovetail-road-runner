using System.Linq;
using System.Collections;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderKey;
using Agents.VictorInsurance.Business.Provider.Services.Interfaces.ApiProviderKey;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using System;
using Agents.VictorInsurance.Business.Provider.Services.Interfaces.ApiProviderKey;

namespace Agents.VictorInsurance.Business.ApiProvider.Services.ApiProviderKey
{
    public class ApiProviderKeyService :IApiProviderKeyService
    {

        private readonly IMapper _mapper;
        public ApiProviderKeyService(
                                IMapper mapper)
        {
            _mapper=mapper;
        }    


        public static List<DomainModel.ApiProviderKey> keys = new List<DomainModel.ApiProviderKey>
{
        new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },
        new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },new DomainModel.ApiProviderKey()
        {
           api_provider_code = Guid.NewGuid().ToString(),api_key = "Authorization",api_key_value = "<userinput>"
        },
       
       
};
        

             public IList<DomainModel.ApiProviderKey> GetKeys(DomainModel.ApiProviderKeySearchModel keySearchModel){
               IEnumerable<DomainModel.ApiProviderKey> result = keys;
              
              
              return result?.ToList();
        }
    }
}