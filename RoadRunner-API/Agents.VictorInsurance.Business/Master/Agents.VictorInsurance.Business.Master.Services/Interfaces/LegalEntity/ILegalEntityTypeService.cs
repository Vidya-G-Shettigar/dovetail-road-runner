using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.LegalEntity;

namespace Agents.VictorInsurance.Business.Master.Services.Interfaces.LegalEntityType
{
 public interface ILegalEntityTypeService
 {
     IEnumerable<DomainModel.LegalEntity> GetLegalEntityTypes();
     
 }

}