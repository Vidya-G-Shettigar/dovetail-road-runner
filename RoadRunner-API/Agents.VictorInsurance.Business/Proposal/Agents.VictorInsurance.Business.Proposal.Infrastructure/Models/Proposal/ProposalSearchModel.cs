namespace Agents.VictorInsurance.Business.Proposal.Infrastructure.Models.Proposal
{
    public class ProposalSearchModel
    {
         public string client_name { get; set; }
         public string proposal_number { get; set; }
         public string proposal_name { get; set; }
         public int? timeperiod { get; set; }
  }
}