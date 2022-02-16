using DomainModel =  Agents.VictorInsurance.Business.Documents.Infrastructure.Models.Carrier;
using System.Collections.Generic;
namespace Agents.VictorInsurance.Business.Documents.Services.Interfaces.Carrier
{
    public interface ICarrierDocumentService
    {
        IEnumerable<DomainModel.CarrierDocument> GetCarrierDocuments(DomainModel.CarrierDocumentSearchModel carrierdocumentSearchModel);
    }
}