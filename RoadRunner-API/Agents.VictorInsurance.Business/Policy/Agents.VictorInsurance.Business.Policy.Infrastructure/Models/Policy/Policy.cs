using System;
namespace Agents.VictorInsurance.Business.Policy.Infrastructure.Models.Policy
{
    public class Policy
    {
         public string client_name { get; set; }
         public string policy_number { get; set; }
         public string business_line { get; set; }
         public DateTime created_on_datetime { get; set; }
         public string created_by { get; set; }
         public int premium { get; set; }
         public string status { get; set; }
         public string state_code { get; set; }
         public DateTime policy_effective_date_datetime { get; set; }
         public DateTime policy_expiration_date_datetime { get; set; }
         public int quote_proposal_number { get; set; }
         public string agent_id { get; set; }
    }
}