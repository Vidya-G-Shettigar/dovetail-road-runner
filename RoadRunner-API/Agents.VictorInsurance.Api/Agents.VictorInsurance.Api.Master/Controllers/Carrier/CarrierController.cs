using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.Carrier;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models;

namespace Agents.VictorInsurance.Master.Api.Controllers.Carrier
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CarrierController : Controller
    {
        private readonly ICarrierService _carrierService;
        public CarrierController(ICarrierService carrierService, IMapper mapper)
        {
            _carrierService = carrierService;
        }

        

        /// <summary>
        /// businesslinecarriers.
        /// </summary>
        /// <returns>businesslinecarrier Resource.</returns>

        [HttpPost]
        [Route("GetBusinessLineCarriers")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.Carrier.Carrier>), 200)]
        public IEnumerable<DomainModel.Carrier.Carrier> GetBusinessLineCarriers([FromBody]DomainModel.BusinessLine.BusinessLine searchModel)
        {

            return _carrierService.GetCarrierByBusinessLine(searchModel);
        }

        
    }
}