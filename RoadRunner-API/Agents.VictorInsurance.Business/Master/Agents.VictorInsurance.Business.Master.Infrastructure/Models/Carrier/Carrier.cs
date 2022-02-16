using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models;

namespace Agents.VictorInsurance.Business.Master.Infrastructure.Models.Carrier
{

    public class Carrier : DomainModel.BusinessLine.BusinessLine
    {
        public string carrier_name { get; set; }
        public string carrier_code { get; set; }
    }
}