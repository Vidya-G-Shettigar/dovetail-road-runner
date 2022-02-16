using System.Linq;
using System.Collections;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderInfo;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using System;
using Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderInfo;

namespace Agents.VictorInsurance.Business.ApiProvider.Services.ApiProviderInfo
{
    public class ApiProviderInfoService : IApiProviderInfoService
    {

        private readonly IMapper _mapper;
        public ApiProviderInfoService(
                                IMapper mapper)
        {
            _mapper=mapper;
        }    


        public static List<DomainModel.ApiProviderInfo> info = new List<DomainModel.ApiProviderInfo>
{
        new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },
        new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "InActive"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "InActive"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "InActive"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "Active"
        },new DomainModel.ApiProviderInfo()
        {
            api_provider_code = Guid.NewGuid().ToString(),api_provider_name = "Briza",status = "InActive"
        },
       
       
};
        

        public IList<ApiProvider.Infrastructure.Models.ApiProviderInfo.ApiProviderInfo> GetInfo(ApiProvider.Infrastructure.Models.ApiProviderInfo.ApiProviderSearchModel infoSearchModel)
        {
            return info;
        }
    }
}