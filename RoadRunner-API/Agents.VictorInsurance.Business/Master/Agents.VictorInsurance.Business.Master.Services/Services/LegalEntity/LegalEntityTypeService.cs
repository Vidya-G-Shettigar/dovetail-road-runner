using Agents.VictorInsurance.Business.Master.Services.Interfaces.LegalEntityType;
using DomainModel = Agents.VictorInsurance.Business.Master.Infrastructure.Models.LegalEntity;
using System.Collections.Generic;
using AutoMapper;
using System;

namespace Agents.VictorInsurance.Business.Master.Services.Services.LegalEntityType
{
    public class LegalEntityTypeService : ILegalEntityTypeService
    {

        private readonly IMapper _mapper;
        public LegalEntityTypeService(
                                IMapper mapper)
        {
            _mapper = mapper;
        }

        public static IEnumerable<DomainModel.LegalEntity> legalEntities = new List<DomainModel.LegalEntity>
        {
            new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Association" },
            new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Common Ownership" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Corporation" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Public" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Government Entity" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Individual" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Sole Proprieter" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Joint Venture" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Labor Union" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Limited Liability Partnership" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Limited Partnership" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Church" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Estate" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Trust" },
                new DomainModel.LegalEntity()
            {
                legal_entity_code= Guid.NewGuid().ToString(), legal_entity_type = "Corporation" },
        };
        public IEnumerable<DomainModel.LegalEntity> GetLegalEntityTypes() => legalEntities;
    }
}