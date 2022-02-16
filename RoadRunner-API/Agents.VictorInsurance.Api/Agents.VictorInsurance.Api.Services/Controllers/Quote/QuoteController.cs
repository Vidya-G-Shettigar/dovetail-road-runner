using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Agents.VictorInsurance.Business.Quote.Services.Interfaces;
using DomainModel = Agents.VictorInsurance.Business.Quote.Infrastructure.Models;

namespace RoadRunner.Quote.API.Controllers.Quote
{
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class QuoteController : Controller
    {
        private readonly IQuoteService _quoteService;
        public QuoteController(IQuoteService quoteService)
        {
            _quoteService = quoteService;
        }

        

        /// <summary>
        /// quotes.
        /// </summary>
        /// <returns>quotes Resource.</returns>

        [HttpPost]
        [Route("GetQuotes")]
        [ProducesResponseType(typeof(IEnumerable<DomainModel.Quote>), 200)]
        public IEnumerable<DomainModel.Quote> GetQuotes([FromBody]DomainModel.QuoteSearchModel quotesearchModel)
        {

            return _quoteService.Quotes(quotesearchModel);
        }

       
    }
}