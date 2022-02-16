using System;

namespace Agents.VictorInsurance.Business.Quote.Infrastructure.Models
{
    public class Quote
    {
        public string client_name { get; set; }
        public string proposal_name {get; set;}
        public string business_line { get; set; }
        public string proposal_number { get; set; }
        public string carrier { get; set; }
        public DateTime created_datetime { get; set; }
        public string created_by { get; set; }
        public int premium { get; set; }
        public string status { get; set; }
        public string state_code { get; set; }
        public DateTime quote_effective_datetime { get; set; }
        public DateTime quote_expiration_datetime { get; set; }
        public DateTime last_updated_on_datetime { get; set; }
        public string agent_id { get; set;}

 }
}