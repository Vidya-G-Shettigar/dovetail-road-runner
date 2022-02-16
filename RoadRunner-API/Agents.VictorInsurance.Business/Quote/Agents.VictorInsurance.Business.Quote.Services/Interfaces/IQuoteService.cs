using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Quote.Infrastructure.Models;
namespace Agents.VictorInsurance.Business.Quote.Services.Interfaces
{
 public interface IQuoteService
 {
      IEnumerable<DomainModel.Quote> Quotes(DomainModel.QuoteSearchModel quoteSearchModel);
 }

}