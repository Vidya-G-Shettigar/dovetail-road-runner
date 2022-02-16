using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models;

namespace Agents.VictorInsurance.Business.Master.Services.Interfaces.Carrier
{
    public interface ICarrierService
    {
        IEnumerable<DomainModel.Carrier.Carrier> GetCarrierByBusinessLine(DomainModel.BusinessLine.BusinessLine searchModel);
    }

}