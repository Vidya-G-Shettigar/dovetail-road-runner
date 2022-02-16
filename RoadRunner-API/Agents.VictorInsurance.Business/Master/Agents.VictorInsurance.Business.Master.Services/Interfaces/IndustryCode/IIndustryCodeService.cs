using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.IndustryCode;

namespace Agents.VictorInsurance.Business.Master.Services.Interfaces.IndustryCode
{
 public interface IIndustryCodeService
 {
     IEnumerable<DomainModel.IndustryCode> GetIndustryCodes();
 }
}