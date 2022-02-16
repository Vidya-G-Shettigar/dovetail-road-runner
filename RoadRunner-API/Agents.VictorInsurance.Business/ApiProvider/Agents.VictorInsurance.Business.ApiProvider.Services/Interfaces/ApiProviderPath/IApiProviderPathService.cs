using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderPath;
namespace Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderPath
{
    public interface IApiProviderPathService
    {
         IList<DomainModel.ApiProviderPath> GetPath(DomainModel.ApiProviderPathSearchModel pathSearchModel);
        
    }
}