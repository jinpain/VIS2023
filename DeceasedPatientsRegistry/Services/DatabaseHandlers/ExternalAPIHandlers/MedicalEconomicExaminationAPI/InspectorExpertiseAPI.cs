namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class InspectorExpertiseAPI : APIController<MedicalEconomicExamination.Domain.Entities.Inspector>
    {
        public InspectorExpertiseAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "Inspector") { }
    }
}
