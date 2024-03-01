using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class CheckTypeAPI : APIController<CheckType>
    {
        public CheckTypeAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "CheckType") { }
    }
}
