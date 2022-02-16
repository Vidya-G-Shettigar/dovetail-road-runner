using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Documents.Services.Interfaces.Carrier;
using DomainModel = Agents.VictorInsurance.Business.Documents.Infrastructure.Models.Carrier;

namespace Agents.VictorInsurance.Master.API.Controllers.BusinessLineDocument
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CarrierDocumentController : Controller
    {
        private readonly ICarrierDocumentService _carrierDocumentService;
        public CarrierDocumentController(ICarrierDocumentService carrierDocumentService, IMapper mapper)
        {
            _carrierDocumentService = carrierDocumentService;
        }

        

        /// <summary>
        /// businesslines.
        /// </summary>
        /// <returns>businesslines Resource.</returns>

        [HttpPost]
        [Route("GetBusinessLineDocuments")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.CarrierDocument>), 200)]
        public IEnumerable<DomainModel.CarrierDocument> GetCarrierDocuments([FromBody]DomainModel.CarrierDocumentSearchModel carrierDocumentSearchModel)
        {

            return _carrierDocumentService.GetCarrierDocuments(carrierDocumentSearchModel);
        }

        
    }
}