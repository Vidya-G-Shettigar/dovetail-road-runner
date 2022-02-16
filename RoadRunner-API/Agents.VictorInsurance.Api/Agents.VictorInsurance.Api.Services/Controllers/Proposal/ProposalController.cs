using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Proposal.Services.Interfaces;
using DomainModel = Agents.VictorInsurance.Business.Proposal.Infrastructure.Models.Proposal;

namespace Agents.VictorInsurance.Api.Controllers.Proposal
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ProposalController : Controller
    {
        private readonly IProposalService _proposalService;
        public ProposalController(IProposalService proposalService)
        {
            _proposalService = proposalService;
        }

        /// <summary>
        /// Lists all proposals.
        /// </summary>
        /// <returns>List of proposal Resource.</returns>

        [HttpPost]
        [Route("GetProposals")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.Proposal>), 200)]
        public IEnumerable<DomainModel.Proposal> GetProposals([FromBody]DomainModel.ProposalSearchModel proposalsearchModel)
        {

            return _proposalService.GetProposals(proposalsearchModel);
        }
        
    }
}