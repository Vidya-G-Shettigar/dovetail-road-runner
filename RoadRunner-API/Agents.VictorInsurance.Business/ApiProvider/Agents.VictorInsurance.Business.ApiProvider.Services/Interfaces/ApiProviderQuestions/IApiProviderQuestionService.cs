using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel =Agents.VictorInsurance.ApiProvider.Infrastructure.Models.ApiProviderQuestion;
namespace Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderQuestions
{   public interface IApiProviderQuestionService
    {
         IList<DomainModel.ApiProviderQuestion> GetQuestionSets(DomainModel.ApiProviderQuestionSearchModel questionsetSearchModel);
        
    }
}