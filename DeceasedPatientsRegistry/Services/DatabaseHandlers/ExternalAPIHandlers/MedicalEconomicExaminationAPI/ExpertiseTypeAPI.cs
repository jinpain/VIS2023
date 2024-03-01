using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class ExpertiseTypeAPI : APIController<ExpertiseType>
    {
        public ExpertiseTypeAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "ExpertiseType") { }
    }
}
