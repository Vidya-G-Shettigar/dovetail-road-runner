using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderInfo;

namespace Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderInfo
{
    public interface IApiProviderInfoService
    {
         IList<DomainModel.ApiProviderInfo> GetInfo(DomainModel.ApiProviderSearchModel infoSearchModel);
        
    }
}