using Agents.VictorInsurance.Business.Master.Services.Interfaces.BusinessLine;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.BusinessLine;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;

namespace Agents.VictorInsurance.Business.Master.Services.Services.BusinessLine
{
    public class BusinessLineService : IBusinessLineService
    {

        private readonly IMapper _mapper;
        public BusinessLineService(
                                    IMapper mapper)
        {
            _mapper = mapper;
        }

        public IEnumerable<DomainModel.BusinessLine> GetBusinessLines() => new List<DomainModel.BusinessLine>()
        {
            new DomainModel.BusinessLine()
            {
                business_line_code = "WC",
                business_line="Workers Compensation"
            },
            new DomainModel.BusinessLine()
            {
                business_line_code = "BOP",
                business_line="Business Owners Policy"
            },
            new DomainModel.BusinessLine()
            {
                business_line_code ="CYB",
                business_line ="Cyber"
            },
            new DomainModel.BusinessLine()
            {
                business_line_code ="PL",
                business_line ="Professional Liability"
            },
            new DomainModel.BusinessLine()
            {
                business_line_code ="GL",
                business_line ="General Liability"
            },
            new DomainModel.BusinessLine()
            {
                business_line_code ="FLD",
                business_line ="Flood"
            },
            new DomainModel.BusinessLine()
            {
                business_line_code ="CA",
                business_line ="Commercial Auto"
            },
            new DomainModel.BusinessLine()
            {
                business_line_code ="UMB",
                business_line ="Umbrella"
            },
        };


        private IEnumerable<DomainModel.BusinessLineBystate> businessLineBystates = new List<DomainModel.BusinessLineBystate>()
        {
            new DomainModel.BusinessLineBystate()
            {
                business_line_code = "WC",
                business_line="Workers Compensation",
                state_code ="CA"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code = "BOP",
                business_line="Business Owners Policy",
                state_code ="CA"
                
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="CYB",
                business_line ="Cyber",
                state_code ="CA"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="PL",
                business_line ="Professional Liability",
                state_code ="AL"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="GL",
                business_line ="General Liability",
                state_code ="AL"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="FLD",
                business_line ="Flood",
                state_code ="AL"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="CA",
                business_line ="Commercial Auto",
                state_code ="AL"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="UMB",
                business_line ="Umbrella",
                state_code ="AZ"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="GL",
                business_line ="General Liability",
                state_code ="NC"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="FLD",
                business_line ="Flood",
                state_code ="NC"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="CA",
                business_line ="Commercial Auto",
                state_code ="NC"
            },
            new DomainModel.BusinessLineBystate()
            {
                business_line_code ="UMB",
                business_line ="Umbrella",
                state_code ="NC"
            }
  
        };
           public IEnumerable<DomainModel.BusinessLineBystate> GetBusinessLineBystates(DomainModel.BusinessLineSearchModel searchModel) {
               
              return businessLineBystates.Where(lob => string.IsNullOrEmpty(searchModel.state_code) 
                                                     || lob.business_line_code.Equals(searchModel.state_code, System.StringComparison.InvariantCultureIgnoreCase)); 
               
           }
    }
}