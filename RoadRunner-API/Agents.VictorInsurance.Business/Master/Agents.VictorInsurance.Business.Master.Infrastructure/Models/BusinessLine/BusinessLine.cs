namespace Agents.VictorInsurance.Business.Master.Infrastructure.Models.BusinessLine
{
    public class BusinessLine
    {
        public string business_line { get; set; }

        public string business_line_code { get; set; }

    }

    public class BusinessLineBystate : BusinessLine
    {
         public string state_code { get; set; }

    }

}