using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class BasisTypeAPI : APIController<BasisType>
    {
        public BasisTypeAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "BasisType") { }
    }
}
