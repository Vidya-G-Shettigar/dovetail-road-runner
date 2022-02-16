using System.Linq;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.State;
using System.Collections.Generic;
using AutoMapper;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.State;

namespace Agents.VictorInsurance.Business.Master.Services.Services.State
{
    public class StateService : IStateService
    {
        private readonly IMapper _mapper;
        public StateService(
                                    IMapper mapper)
        {
            _mapper = mapper;
        }

        public static IList<DomainModel.State> states = new List<DomainModel.State>
        {
            new DomainModel.State()
            {
                state_name= "Texas", state_code= "TX"
            },
            new DomainModel.State()
            {
                state_name= "Missouri", state_code= "MO"
            },
            new DomainModel.State()
            {
                state_name= "Montana", state_code= "MT"
            },
            new DomainModel.State()
            {
                state_name= "Ohio", state_code= "OH"
            },
            new DomainModel.State()
            {
                state_name= "Alabama", state_code= "AL"
            },
            new DomainModel.State()
            {
                state_name= "Alaska", state_code= "AK"
            },
            new DomainModel.State()
            {
                state_name= "Arizona", state_code= "AZ"
            },
            new DomainModel.State()
            {
                state_name= "California", state_code= "CA"
            },
            new DomainModel.State()
            {
                state_name= "Florida", state_code= "FL"
            },
            new DomainModel.State()
            {
                state_name= "Georgia", state_code= "GA"
            },
            new DomainModel.State()
            {
                state_name= "Illinois", state_code= "IL"
            },
            new DomainModel.State()
            {
                state_name= "New Jersey", state_code= "NJ"
            },
            new DomainModel.State()
            {
                state_name= "Washington", state_code= "WA"
            },
            new DomainModel.State()
            {
                state_name= "Tennessee", state_code= "TN"
            },
            new DomainModel.State()
            {
                state_name= "New York", state_code= "NY"
            }
        };
        public IEnumerable<DomainModel.State> GetStates() => states;
    }
}