using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class InsuranceCompanyAPI : APIController<InsuranceCompany>
    {
        public InsuranceCompanyAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "InsuranceCompany") { }
    }
}
