using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class UnitTypeAPI : APIController<UnitType>
    {
        public UnitTypeAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "UnitType") { }
    }
}
