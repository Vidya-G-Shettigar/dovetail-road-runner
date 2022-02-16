using System;
namespace Agents.VictorInsurance.Business.Documents.Infrastructure.Models.Carrier
{
    public class CarrierDocument
    {
        public Guid document_code { get; set; }
        public string carrier_code { get; set; }         
        public string document_name { get; set; }
        public string document_link { get; set; }
        public string business_line_code { get; set; }
        public string business_line { get; set; }

    }
}