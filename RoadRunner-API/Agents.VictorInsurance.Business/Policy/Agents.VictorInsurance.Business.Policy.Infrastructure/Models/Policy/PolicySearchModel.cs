namespace Agents.VictorInsurance.Business.Policy.Infrastructure.Models.Policy
{
    public class PolicySearchModel
    {
        public string policy_number { get; set; }     
        public string client_name { get; set; }
        public string status { get; set; }
        public int? timeperiod { get; set; }
        public bool is_recent { get; set;} = false;
        public string agent_id { get; set; } 
    }
}