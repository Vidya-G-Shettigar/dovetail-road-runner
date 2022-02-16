using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.ClassCode;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.ClassCode;

namespace Agents.VictorInsurance.Master.Api.Controllers.ClassCode
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ClassCodeController : Controller
    {
        private readonly IClassCodeService _classcodeService;
        public ClassCodeController(IClassCodeService classcodeService)
        {
            _classcodeService = classcodeService;
        }

        /// <summary>
        /// Lists all class codes.
        /// </summary>
        /// <returns>List of classcode Resource.</returns>


        [HttpPost]
        [Route("GetClassCodes")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.ClassCode>), 200)]
        public IEnumerable<DomainModel.ClassCode> GetClassCodes()
        {

            return _classcodeService.GetClassCodes();
        }

        
    }
}