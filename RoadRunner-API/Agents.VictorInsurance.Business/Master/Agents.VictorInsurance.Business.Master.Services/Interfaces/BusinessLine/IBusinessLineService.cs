using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.BusinessLine;

namespace Agents.VictorInsurance.Business.Master.Services.Interfaces.BusinessLine
{
 public interface IBusinessLineService
 {
    IEnumerable<DomainModel.BusinessLine> GetBusinessLines();
 }

}