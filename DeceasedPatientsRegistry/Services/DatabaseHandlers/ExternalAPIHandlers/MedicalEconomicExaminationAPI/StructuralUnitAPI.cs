using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class StructuralUnitAPI : APIController<StructuralUnit>
    {
        public StructuralUnitAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "StructuralUnit") { }
    }
}
