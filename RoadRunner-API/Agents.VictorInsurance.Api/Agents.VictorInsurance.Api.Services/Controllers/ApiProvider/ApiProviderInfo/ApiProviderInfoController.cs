using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderInfo;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderInfo;

namespace Agents.VictorInsurance.ApiProvider.Services.Controllers.ApiProvider.ApiProviderInfo
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ApiProviderInfoController : Controller
    {
        private readonly IApiProviderInfoService _infoService;
        public ApiProviderInfoController(IApiProviderInfoService infoService)
        {
            _infoService = infoService;
        }

        

        /// <summary>
        /// Gets the provider info based on the provider code
        /// </summary>
        /// <returns>returns provider info.</returns>

        [HttpPost]
        [Route("GetInfo")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.ApiProviderInfo>), 200)]
        public IEnumerable<DomainModel.ApiProviderInfo> GetInfo([FromBody]DomainModel.ApiProviderSearchModel infosearchModel)
        {

            return _infoService.GetInfo(infosearchModel);
        }

       
    }
}