using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.ClassCode;

namespace Agents.VictorInsurance.Business.Master.Services.Interfaces.ClassCode
{
 public interface IClassCodeService
 {
     IEnumerable<DomainModel.ClassCode> GetClassCodes();
 }
}