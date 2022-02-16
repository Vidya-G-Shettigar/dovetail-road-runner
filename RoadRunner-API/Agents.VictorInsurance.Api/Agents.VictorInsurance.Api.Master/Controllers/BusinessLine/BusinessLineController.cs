using System.Collections.Generic;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.BusinessLine;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.BusinessLine;

namespace Agents.VictorInsurance.Api.Master.Controllers.BusinessLine
{

    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BusinessLineController :Controller
    { private readonly IBusinessLineService _businessLineService;
        public BusinessLineController(IBusinessLineService businessLineService, IMapper mapper)
        {
            _businessLineService = businessLineService;
        }

        /// <summary>
        /// Gets the business line based on the business line code .
        /// </summary>
        /// <returns>returns the list of business lines </returns>
        [HttpPost]
        [Route("GetBusinessLines")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.BusinessLine>), 200)]
        public IEnumerable<DomainModel.BusinessLine> GetBusinessLines()
        {
            return _businessLineService.GetBusinessLines();
        }

    }
}