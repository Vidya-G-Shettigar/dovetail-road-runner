using System.Collections.Generic;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.State;

namespace Agents.VictorInsurance.Business.Master.Services.Interfaces.State
{
    public interface IStateService
    {
        IEnumerable<DomainModel.State> GetStates();
    }
}