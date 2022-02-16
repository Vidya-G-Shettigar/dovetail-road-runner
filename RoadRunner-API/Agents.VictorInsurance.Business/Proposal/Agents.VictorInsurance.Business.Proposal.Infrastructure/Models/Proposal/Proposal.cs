using System;
namespace Agents.VictorInsurance.Business.Proposal.Infrastructure.Models.Proposal
{
    public class Proposal
    {
         public string client_name { get; set; }
         public string proposal_number { get; set; }
         public string proposal_name { get; set; }
        public DateTime proposal_created_datetime { get; set; }
         public string proposal_created_by { get; set; }

    }
}