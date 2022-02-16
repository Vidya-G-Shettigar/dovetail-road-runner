using System;
using Agents.VictorInsurance.Business.Documents.Services.Interfaces.Carrier;
using DomainModel = Agents.VictorInsurance.Business.Documents.Infrastructure.Models.Carrier;
using System.Linq;
using System.Collections.Generic;

namespace Agents.VictorInsurance.Business.Documents.Services.Services.Carrier
{
    public class CarrierDocumentService : ICarrierDocumentService
    {
        IEnumerable<DomainModel.CarrierDocument> carrierDocuments = new List<DomainModel.CarrierDocument>
        {
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite Commercial General Liability form", document_link= "HomesiteGL.pdf" , business_line= "GL", carrier_code = Guid.NewGuid().ToString().ToString()
            },
                new DomainModel.CarrierDocument()
            {
                document_name= "Homesite Commercial General Liability form", document_link= "HomesiteGL.pdf" , business_line= "GL", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite BOP", document_link= "HomesiteBOP.pdf" , business_line= "BOP", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite Commercial Inland Marine", document_link= "HomesiteMarine.pdf" , business_line= "BOP", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite Contractors Equipment Coverage form", document_link= "HomesiteContractorsCoverage.pdf" , business_line= "BOP", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "AmTrust Workers Compensation Financial form", document_link= "AmTrustWorkersCompensationfinancial.pdf" , business_line= "WC", carrier_code = Guid.NewGuid().ToString()
            }, new DomainModel.CarrierDocument()
            {
                document_name= "AmTrust Cyber Speciman Policy form", document_link= "AmTrustCyberSpecimenPolicyForm.pdf" , business_line= "WC", carrier_code = Guid.NewGuid().ToString()
            }, new DomainModel.CarrierDocument()
            {
                document_name= "AmTrust EPLI Specimen form", document_link= "AmTrustEPLISpecimen.pdf" , business_line= "WC", carrier_code = Guid.NewGuid().ToString()
            }, new DomainModel.CarrierDocument()
            {
                document_name= "AmTrust Workers Equipment Coverage form", document_link= "AmTrustWorkersEquipmentCoverage.pdf" , business_line= "WC", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite Misc Professional Liability Endorsement", document_link= "HomesiteGL.pdf" , business_line= "GL", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite Misc Items Blanket Coverage", document_link= "HomesiteMiscItemsBlanketCoverage.pdf" , business_line= "GL", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite Deductible  Liability Endorsement", document_link= "HomesiteGL.pdf" , business_line= "GL", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite Damage to properties of others endorsement form", document_link= "HomesiteDamagetopropertiesofothers.pdf" , business_line= "GL", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite BOP Time Element Specimen", document_link= "HomesiteBOPTimeElementSpecimen.pdf" , business_line= "BOP", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite BOP Printers E and O Specimen", document_link= "HomesiteBOPPrinters.pdf" , business_line= "BOP", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite BOP Spoilage cover Specimen", document_link= "HomesiteBOPSpoliageCover.pdf" , business_line= "BOP", carrier_code = Guid.NewGuid().ToString()
            },
            new DomainModel.CarrierDocument()
            {
                document_name= "Homesite BOP Time Element Specimen", document_link= "HomesiteBOPTimeElement.pdf" , business_line= "BOP", carrier_code = Guid.NewGuid().ToString()
            },
        };

        public IEnumerable<DomainModel.CarrierDocument> GetCarrierDocuments(DomainModel.CarrierDocumentSearchModel carrierDocumentSearchModel)
        {
            return carrierDocuments.Where(doc => string.IsNullOrEmpty(carrierDocumentSearchModel.carrier_code) 
                                                    || doc.carrier_code.Equals(carrierDocumentSearchModel.carrier_code, StringComparison.InvariantCultureIgnoreCase));
        }

    }
}