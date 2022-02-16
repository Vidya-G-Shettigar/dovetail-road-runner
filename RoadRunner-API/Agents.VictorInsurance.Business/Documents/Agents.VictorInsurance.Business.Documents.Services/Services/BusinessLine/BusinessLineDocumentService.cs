using System.Linq;
using System.Collections;
using Agents.VictorInsurance.Business.Documents.Services.Interfaces.BusinessLine;
using DomainModel = Agents.VictorInsurance.Business.Documents.Infrastructure.Models.BusinessLine;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using System;

namespace Agents.VictorInsurance.Business.Documents.Services.Services.BusinessLine
{
    public class BusinessLineDocumentService : IBusinessLineDocumentService
    {

        private readonly IMapper _mapper;
        public BusinessLineDocumentService(
                                            IMapper mapper)
        {
            _mapper = mapper;
        }    

      IEnumerable<DomainModel.BusinessLineDocument> businessLineDocuments = new List<DomainModel.BusinessLineDocument>
        {
            new DomainModel.BusinessLineDocument()
            {
                document_name= "AmTrust - Workers Compensation Specimen Policy form", document_link= "AmTrust-WorkersCompensationSpecimenPolicyform.pdf" , business_line= "WC"
            },
            new DomainModel.BusinessLineDocument()
            {
                document_name= "Homesite Commercial General Liability form", document_link= "HomesiteGL.pdf" , business_line= "GL"
            },
            new DomainModel.BusinessLineDocument()
            {
                document_name= "Homesite BOP", document_link= "HomesiteBOP.pdf" , business_line= "BOP"
            },
            new DomainModel.BusinessLineDocument()
            {
                document_name= "Homesite Commercial Inland Marine", document_link= "HomesiteMarine.pdf" , business_line= "BOP"
            },
            new DomainModel.BusinessLineDocument()
            {
                document_name= "Homesite Contractors Equipment Coverage form", document_link= "HomesiteContractorsCoverage.pdf" , business_line= "BOP"
            },
        };

         public IEnumerable<DomainModel.BusinessLineDocument> GetBusinessLineDocuments(DomainModel.BusinessLineDocumentSearchModel businessLineDocumentSearchModel){
            var result = businessLineDocuments;

             if(!string.IsNullOrEmpty(businessLineDocumentSearchModel.business_line))
                result = result?.Where(doc => doc.business_line.Equals(businessLineDocumentSearchModel.business_line, StringComparison.InvariantCultureIgnoreCase));
            if(!string.IsNullOrEmpty(businessLineDocumentSearchModel.business_line_code))
                result = result?.Where(doc => doc.business_line_code.Equals(businessLineDocumentSearchModel.business_line_code, StringComparison.InvariantCultureIgnoreCase));
            return result;

         }
        
    }
}