namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class DepartmentExpertiseAPI : APIController<MedicalEconomicExamination.Domain.Entities.Department>
    {
        public DepartmentExpertiseAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "Department") { }
    }
}
