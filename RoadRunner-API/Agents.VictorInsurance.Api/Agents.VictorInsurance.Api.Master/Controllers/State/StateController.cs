using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.State;
using Agents.VictorInsurance.Business.Master.Services.Services.State;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.State;

namespace RoadRunner.Master.API.Controllers.State
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class StateController : Controller
    {
        private readonly IStateService _stateService;
        public StateController(IStateService stateService, IMapper mapper)
        {
            _stateService = stateService;
        }

        

        /// <summary>
        /// states.
        /// </summary>
        /// <returns>states Resource.</returns>

        [HttpGet]
        [Route("GetStates")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.State>), 200)]
        public IEnumerable<DomainModel.State> GetStates()
        {

            return _stateService.GetStates();
        }

        
    }
}