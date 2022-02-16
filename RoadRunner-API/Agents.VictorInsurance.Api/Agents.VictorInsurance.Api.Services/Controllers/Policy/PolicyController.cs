using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Policy.Services.Interfaces;
using DomainModel = Agents.VictorInsurance.Business.Policy.Infrastructure.Models.Policy;

namespace Agents.VictorInsurance.Api.Policy.Controllers.Policy
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PolicyController : Controller
    {
        private readonly IPolicyService _policyService;
        public PolicyController(IPolicyService policyService, IMapper mapper)
        {
            _policyService = policyService;
        }

        /// <summary>
        /// policies.
        /// </summary>
        /// <returns>policies Resource.</returns>

        [HttpPost]
        [Route("GetPolicies")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.Policy>), 200)]
        public IEnumerable<DomainModel.Policy> GetPolicies([FromBody]DomainModel.PolicySearchModel searchModel)
        {

            return _policyService.GetPolicies(searchModel);
        }

    }
}