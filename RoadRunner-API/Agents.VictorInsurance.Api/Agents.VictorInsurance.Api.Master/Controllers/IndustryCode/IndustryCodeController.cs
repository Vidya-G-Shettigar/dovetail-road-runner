using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.IndustryCode;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.IndustryCode;

namespace Agents.VictorInsurance.Master.Api.Controllers.IndustryCode
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class IndustryCodeController : Controller
    {
        private readonly IIndustryCodeService _industryCodeService;
        public IndustryCodeController(IIndustryCodeService industryCodeService)
        {
            _industryCodeService = industryCodeService;
        }

        /// <summary>
        /// Lists all industry codes.
        /// </summary>
        /// <returns>List of industrycode Resource.</returns>
        [HttpGet]
        [Route("GetIndustryCodes")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.IndustryCode>), 200)]
        public IEnumerable<DomainModel.IndustryCode> GetIndustryCodes()
        {

            return _industryCodeService.GetIndustryCodes();
        }

        
    }
}