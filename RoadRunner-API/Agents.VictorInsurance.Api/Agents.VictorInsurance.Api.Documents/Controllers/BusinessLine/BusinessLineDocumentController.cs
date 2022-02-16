using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Documents.Services.Interfaces.BusinessLine;
using DomainModel = Agents.VictorInsurance.Business.Documents.Infrastructure.Models.BusinessLine;

namespace Agents.VictorInsurance.Master.API.Controllers.BusinessLineDocument
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BusinessLineDocumentController : Controller
    {
        private readonly IBusinessLineDocumentService _businesslinedocumentService;
        public BusinessLineDocumentController(IBusinessLineDocumentService businesslinedocumentService, IMapper mapper)
        {
            _businesslinedocumentService = businesslinedocumentService;
        }

        

        /// <summary>
        /// businesslines.
        /// </summary>
        /// <returns>businesslines Resource.</returns>

        [HttpPost]
        [Route("GetBusinessLineDocuments")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.BusinessLineDocument>), 200)]
        public IEnumerable<DomainModel.BusinessLineDocument> GetBusinessLineDocuments([FromBody]DomainModel.BusinessLineDocumentSearchModel businesslinedocumentsearchModel)
        {

            return _businesslinedocumentService.GetBusinessLineDocuments(businesslinedocumentsearchModel);
        }

        
    }
}