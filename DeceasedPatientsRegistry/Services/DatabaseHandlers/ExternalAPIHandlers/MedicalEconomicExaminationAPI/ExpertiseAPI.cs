using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class ExpertiseAPI : APIController<Expertise>
    {
        public ExpertiseAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "Expertise") { }
    }
}
