using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class BasisCheckAPI : APIController<BasisCheck>
    {
        public BasisCheckAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "BasisCheck") { }
    }
}
