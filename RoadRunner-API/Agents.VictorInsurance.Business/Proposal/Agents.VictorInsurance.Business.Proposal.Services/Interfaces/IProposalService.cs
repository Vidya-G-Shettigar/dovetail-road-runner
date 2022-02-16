using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Proposal.Infrastructure.Models.Proposal;

namespace Agents.VictorInsurance.Business.Proposal.Services.Interfaces
{
    public interface IProposalService
    {
         IEnumerable<DomainModel.Proposal> GetProposals(DomainModel.ProposalSearchModel proposalSearchModel);
        
    }
}