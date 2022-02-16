using System.Linq;
using Agents.VictorInsurance.Business.Proposal.Services.Interfaces;
using DomainModel = Agents.VictorInsurance.Business.Proposal.Infrastructure.Models.Proposal;
using System.Collections.Generic;
using AutoMapper;
using System;

namespace Agents.VictorInsurance.Business.Proposal.Services.Services
{
    public class ProposalService :IProposalService
    {

        private readonly IMapper _mapper;
        public ProposalService(
                                IMapper mapper)
        {
            _mapper=mapper;
        }    


       IEnumerable<DomainModel.Proposal> proposals = new List<DomainModel.Proposal>
{
        new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC003",proposal_name="Reg_BOP_TC003",proposal_number = "618907aef5220149400124ae",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
        new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC004",proposal_name="Reg_BOP_TC004",proposal_number = "618907aef5220149400124ab",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
        new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC005",proposal_name="Reg_BOP_TC005",proposal_number = "618907aef5220149400124ac",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC006",proposal_name="Reg_BOP_TC006",proposal_number = "618907aef5220149400124ad",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC007",proposal_name="Reg_BOP_TC007",proposal_number = "618907aef5220149400123ae",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC008",proposal_name="Reg_BOP_TC008",proposal_number = "618907aef5220149400124af",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
        new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC009",proposal_name="Reg_BOP_TC009",proposal_number = "618907aef5220149400125ab",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC010",proposal_name="Reg_BOP_TC010",proposal_number = "618907aef5220149400126ac",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC011",proposal_name="Reg_BOP_TC011",proposal_number = "618907aef5220149400224ad",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC012",proposal_name="Reg_BOP_TC012",proposal_number = "618907aef5220149400124ae",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC013",proposal_name="Reg_BOP_TC013",proposal_number = "618907aef5220149500124af",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
        new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC014",proposal_name="Reg_BOP_TC014",proposal_number = "618907aef5220149400115ab",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC015",proposal_name="Reg_BOP_TC015",proposal_number = "618907aef5220149400116ac",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC016",proposal_name="Reg_BOP_TC016",proposal_number = "618907aef4220149400224ad",proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        },
new DomainModel.Proposal()
        {
            client_name = "Reg_BOP_TC017",proposal_name="Reg_BOP_TC017",proposal_number = "618907aef5220149401134ae", proposal_created_datetime = Convert.ToDateTime("10/01/2011"),
              proposal_created_by = "Test_user"
        }
       
       

    };
             public IEnumerable<DomainModel.Proposal> GetProposals(DomainModel.ProposalSearchModel proposalSearchModel){
               IEnumerable<DomainModel.Proposal> result = proposals;
              if(!string.IsNullOrEmpty(proposalSearchModel.client_name))
                  result = result?.Where(proposal =>  proposal.client_name.Contains(proposalSearchModel.client_name,StringComparison.InvariantCultureIgnoreCase));
              if(!string.IsNullOrEmpty(proposalSearchModel.proposal_number))
                result = result?.Where(proposal =>  proposal.proposal_number.Contains(proposalSearchModel.proposal_number,StringComparison.InvariantCultureIgnoreCase));
              if(!string.IsNullOrEmpty(proposalSearchModel.proposal_name))
                result = result?.Where(proposal =>  string.Equals(proposalSearchModel.proposal_name, proposal.proposal_name, StringComparison.InvariantCultureIgnoreCase));
              if(proposalSearchModel.timeperiod != null || proposalSearchModel.timeperiod > 0)
                result = result?.Where(proposal => proposal.proposal_created_datetime.Date>= DateTime.Now.AddMonths(proposalSearchModel.timeperiod.Value* -1).Date
                                              && proposal.proposal_created_datetime.Date <= DateTime.Now.Date );
              
              return result;
        }

    }
}