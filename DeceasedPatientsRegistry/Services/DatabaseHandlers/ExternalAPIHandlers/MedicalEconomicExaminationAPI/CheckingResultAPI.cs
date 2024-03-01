using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class CheckingResultAPI : APIController<CheckingResult>
    {
        public CheckingResultAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "CheckingResult") { }
    }
}
