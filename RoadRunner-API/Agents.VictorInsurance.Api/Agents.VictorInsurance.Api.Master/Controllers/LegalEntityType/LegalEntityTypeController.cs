using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.LegalEntityType;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.LegalEntity;

namespace Agents.VictorInsurance.Master.Api.Controllers.LegalEntityType
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class LegalEntityTypeController : Controller
    {
        private readonly ILegalEntityTypeService _legalEntityTypeService;
        public LegalEntityTypeController(ILegalEntityTypeService legalEntityTypeService, IMapper mapper)
        {
            _legalEntityTypeService = legalEntityTypeService;
        }

        /// <summary>
        ///  legal entity types.
        /// </summary>
        /// <returns>legal entity types Resource.</returns>

        [HttpPost]
        [Route("GetLegalEntityTypes")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.LegalEntity>), 200)]
        public IEnumerable<DomainModel.LegalEntity> GetLegalEntityTypes( )
        {

            return _legalEntityTypeService.GetLegalEntityTypes();
        }
        
    }
}