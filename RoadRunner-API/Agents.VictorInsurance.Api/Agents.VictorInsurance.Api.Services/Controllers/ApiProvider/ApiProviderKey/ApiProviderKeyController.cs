using System.Collections.Generic;
using System.Threading.Tasks;
using Agents.VictorInsurance.Business.Provider.Services.Interfaces.ApiProviderKey;
using Microsoft.AspNetCore.Mvc;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderKey;

namespace Agents.VictorInsurance.ApiProvider.Services.Controllers.ApiProvider.ApiProviderKey
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ApiProviderKeyController : Controller
    {
        private readonly IApiProviderKeyService _keyService;
        public ApiProviderKeyController(IApiProviderKeyService keyService)
        {
            _keyService = keyService;
        }

        

        /// <summary>
        /// Gets the provider keys based on the provider code
        /// </summary>
        /// <returns>returns list of provider keys.</returns>

        [HttpPost]
        [Route("GetKeys")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.ApiProviderKey>), 200)]
        public IEnumerable<DomainModel.ApiProviderKey> GetKeys([FromBody]DomainModel.ApiProviderKeySearchModel keysearchModel)
        {

            return _keyService.GetKeys(keysearchModel);
        }

       
    }
}