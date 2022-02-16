using System.Linq;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.Carrier;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models;
using System.Collections.Generic;
using AutoMapper;
using System;

namespace Agents.VictorInsurance.Business.Master.Services.Services.Carrier
{
    public class CarrierService : ICarrierService
    {

        private readonly IMapper _mapper;
        public CarrierService(
                                IMapper mapper)
        {
            _mapper = mapper;
        }

        private IList<DomainModel.Carrier.Carrier> businessLineCarrier  = new List<DomainModel.Carrier.Carrier>()
        {
            new DomainModel.Carrier.Carrier()
            {
                business_line = "Workers Compensation",
                business_line_code = "WC",
                carrier_code = Guid.NewGuid().ToString(),
                carrier_name = "Amtrust"
            },  
             new DomainModel.Carrier.Carrier()
            {
                 business_line = "General Liability",
                business_line_code = "GL",
                carrier_code = Guid.NewGuid().ToString(),
                carrier_name = "Homesite"
            }, 
             new DomainModel.Carrier.Carrier()
            {
                business_line = "Business Owners Policy",
                business_line_code = "BOP",
                carrier_code = Guid.NewGuid().ToString(),
                carrier_name = "Homesite"
            }, 
             new DomainModel.Carrier.Carrier()
            {
                 business_line = "Workers Compensation",
                business_line_code = "WC",
                carrier_code = Guid.NewGuid().ToString(),
                carrier_name = "Markel"
            }, 
             new DomainModel.Carrier.Carrier()
            {
                 business_line = "Workers Compensation",
                business_line_code = "WC",
                carrier_code = Guid.NewGuid().ToString(),
                carrier_name = "Employer"
            }, 
             new DomainModel.Carrier.Carrier()
            {
                business_line = "Workers Compensation",
                business_line_code = "WC"
            }, 
        };
        public IEnumerable<DomainModel.Carrier.Carrier> GetCarrierByBusinessLine(DomainModel.BusinessLine.BusinessLine searchModel)
        {
            IEnumerable<DomainModel.Carrier.Carrier> result = businessLineCarrier;
            if(!string.IsNullOrEmpty(searchModel.business_line))
                result = result?.Where(carrier => carrier.business_line.Equals(searchModel.business_line, StringComparison.InvariantCultureIgnoreCase));
            if(!string.IsNullOrEmpty(searchModel.business_line_code))
                result = result?.Where(carrier => carrier.business_line_code.Equals(searchModel.business_line_code, StringComparison.InvariantCultureIgnoreCase));
            return result;

        }
        
    }
}