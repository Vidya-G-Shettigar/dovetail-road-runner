using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel = Agents.VictorInsurance.Business.Documents.Infrastructure.Models.BusinessLine;

namespace Agents.VictorInsurance.Business.Documents.Services.Interfaces.BusinessLine
{
 public interface IBusinessLineDocumentService
 {
    IEnumerable<DomainModel.BusinessLineDocument> GetBusinessLineDocuments(DomainModel.BusinessLineDocumentSearchModel businesslinedocumentSearchModel);
 }

}