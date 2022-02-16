using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Policy.Infrastructure.Models.Policy;
namespace Agents.VictorInsurance.Business.Policy.Services.Interfaces
{
    public interface IPolicyService
    {
         IEnumerable<DomainModel.Policy> GetPolicies(DomainModel.PolicySearchModel policySearchModel);
    }
}