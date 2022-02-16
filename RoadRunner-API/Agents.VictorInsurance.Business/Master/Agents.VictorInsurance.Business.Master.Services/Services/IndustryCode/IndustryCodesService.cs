using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.IndustryCode;
using System.Collections.Generic;
using Agents.VictorInsurance.Business.Master.Services.Interfaces.IndustryCode;
using AutoMapper;

namespace Agents.VictorInsurance.Business.Master.Services.Services.IndustryCode
{
    public class IndustryCodeService : IIndustryCodeService
    {

        private readonly IMapper _mapper;
        public IndustryCodeService(
                                IMapper mapper)
        {
            _mapper = mapper;
        }

        public static IList<DomainModel.IndustryCode> industryCodes = new List<DomainModel.IndustryCode>
{
        new DomainModel.IndustryCode()
        {
            naics_code= 443142 , industry_name= "Electronics Stores",
        },
        new DomainModel.IndustryCode()
        {
            naics_code= 113210 , industry_name= "Forest Nurseries and Gathering of Forest Products",
        },
        new DomainModel.IndustryCode()
        {
            naics_code= 115310 , industry_name= "Support Activities for Forestry",
        },
        new DomainModel.IndustryCode()
        {
            naics_code= 236188 , industry_name= "Resodential Remodelers",
        },
        new DomainModel.IndustryCode()
        {
            naics_code= 237110 , industry_name= "Water and Sewer Line Related Industry",
        },
         new DomainModel.IndustryCode()
        {
            naics_code= 321114 , industry_name= "Wood Preservation",
        },
        new DomainModel.IndustryCode()
        {
            naics_code= 311941 , industry_name= "Mayonnaise and other Prepared Sauce Manufacturing Industry",
        },
         new DomainModel.IndustryCode()
        {
            naics_code= 444120 , industry_name= "Paint and Wallpaper Stores",
        },
         new DomainModel.IndustryCode()
        {
            naics_code= 444130 , industry_name= "Hardware Stores",
        },
        new DomainModel.IndustryCode()
        {
            naics_code= 444210 , industry_name= "Outdoor Power Equipment Stores",
        },
         new DomainModel.IndustryCode()
        {
            naics_code= 448120 , industry_name= "Womens Clothing Stores",
        },
         new DomainModel.IndustryCode()
        {
            naics_code= 448130 , industry_name= "Childrens and Infants Clothing Stores",
        },
        new DomainModel.IndustryCode()
        {
            naics_code= 448150 , industry_name= "Clothing Accessory Stores",
        },
          new DomainModel.IndustryCode()
        {
            naics_code= 451110 , industry_name= "Sporting Goods Stores",
        },
         new DomainModel.IndustryCode()
        {
            naics_code= 451120 , industry_name= "Hobby, toy and games Stores",
        },
         new DomainModel.IndustryCode()
        {
            naics_code= 451211 , industry_name= "Book Stores",
        },
        new DomainModel.IndustryCode()
        {
            naics_code= 722511 , industry_name= "Full service Restaurants",
        }
};
        public IEnumerable<DomainModel.IndustryCode> GetIndustryCodes() => industryCodes;
    }
}