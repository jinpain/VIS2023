using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class ClaimAPI : APIController<Claim>
    {
        public ClaimAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "Claim") { }
    }
}
