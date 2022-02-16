using Agents.VictorInsurance.Business.Master.Services.Interfaces.ClassCode;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.ClassCode;
using System.Collections.Generic;
using AutoMapper;

namespace Agents.VictorInsurance.Business.Master.Services.Services.ClassCode
{
    public class ClassCodeService : IClassCodeService
    {

        private readonly IMapper _mapper;
        public ClassCodeService(
                                IMapper mapper)
        {
            _mapper = mapper;
        }    

        public static IList<DomainModel.ClassCode> classCodes = new List<DomainModel.ClassCode>
{
        new DomainModel.ClassCode()
        {
            class_code= 0005 , class_code_name= "Farm Nursery Employees & Drivers",
        },
        new DomainModel.ClassCode()
        {
           class_code= 0012 , class_code_name= "Paid Furloughed Employees",
        },
        new DomainModel.ClassCode()
        {
           class_code= 0035 , class_code_name= "Farm Florist & Drivers",
        }, 
        new DomainModel.ClassCode()
        {
           class_code= 0042 , class_code_name= "Hydro - Mulching & Drivers",
        }, 
        new DomainModel.ClassCode()
        {
           class_code= 0079 , class_code_name= "Farm - Berry or Vineyard & Drivers",
        },
         new DomainModel.ClassCode()
        {
           class_code= 0113 , class_code_name= "Farm - Fish Hatchery & Drivers",
        }, 
        new DomainModel.ClassCode()
        {
            class_code= 0925 , class_code_name= "Hardware Store - Retail",
        },
         new DomainModel.ClassCode()
        {
           class_code= 204 , class_code_name= "Shoe Findings Manufacturing",
        },
         new DomainModel.ClassCode()
        {
           class_code= 2388 , class_code_name= "Embroidery Manufacturing",
        }, 
        new DomainModel.ClassCode()
        {
            class_code= 2416 , class_code_name= "Yarn or Thread Dyeing or Finishing",
        },
         new DomainModel.ClassCode()
        {
           class_code= 3110 , class_code_name= "Tool Manufacturing - Drop or Machined Forged: Forging",
        },
         new DomainModel.ClassCode()
        {
            class_code= 3255 , class_code_name= "Wire Cloth Manufacturing",
        }, 
        new DomainModel.ClassCode()
        {
           class_code= 4130 , class_code_name= "Glass Merchants",
        },
         new DomainModel.ClassCode()
        {
           class_code= 8046 , class_code_name= "Automobile - Recycling",
        },
          new DomainModel.ClassCode()
        {
           class_code= 8742 , class_code_name= "Accntng/Audit Firm - Outside Sales",
        },
         new DomainModel.ClassCode()
        {
           class_code= 9522 , class_code_name= "Automobile, Bus, Truck or Trailer Body Manufacturing: Upholstering",
        },
};
        IEnumerable<DomainModel.ClassCode> IClassCodeService.GetClassCodes() => classCodes;
    }
}