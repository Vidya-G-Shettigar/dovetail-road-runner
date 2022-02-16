namespace Agents.VictorInsurance.Business.Quote.Infrastructure.Models
{
    public class QuoteSearchModel
    {
        public string proposal_number { get; set; }     
        public string client_name { get; set; }
        public string status { get; set; }
        public int? timeperiod { get; set; }
        public string agent_id { get; set; }
        public bool is_recent {get ; set;} = false;
    }
}