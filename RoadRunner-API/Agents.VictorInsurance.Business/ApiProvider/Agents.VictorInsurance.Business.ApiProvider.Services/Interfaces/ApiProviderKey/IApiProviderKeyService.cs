using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderKey;
namespace Agents.VictorInsurance.Business.Provider.Services.Interfaces.ApiProviderKey
{
    public interface IApiProviderKeyService
    {
         IList<DomainModel.ApiProviderKey> GetKeys(DomainModel.ApiProviderKeySearchModel KeySearchModel);
        
    }
}