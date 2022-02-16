using System.Collections.Generic;
using System.Threading.Tasks;
using Agents.VictorInsurance.Business.ApiProvider.Services.Interfaces.ApiProviderPath;
using Microsoft.AspNetCore.Mvc;
using DomainModel = Agents.VictorInsurance.Business.ApiProvider.Infrastructure.Models.ApiProviderPath;

namespace RoadRunner.Provider.API.Controllers.Path
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PathController : Controller
    {
        private readonly IApiProviderPathService _pathService;
        public PathController(IApiProviderPathService pathService)
        {
            _pathService = pathService;
        }

        

        /// <summary>
        /// Gets the provider path based on provider name and code
        /// </summary>
        /// <returns>returns list of path.</returns>

        [HttpPost]
        [Route("GetPath")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.ApiProviderPath>), 200)]
        public IEnumerable<DomainModel.ApiProviderPath> GetPath([FromBody]DomainModel.ApiProviderPathSearchModel pathsearchModel)
        {

            return _pathService.GetPath(pathsearchModel);
        }

       
    }
}