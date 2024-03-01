using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class SanctionAPI : APIController<Sanction>
    {
        public SanctionAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "Sanction") { }
    }
}
