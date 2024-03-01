namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class PatientExpertiseAPI : APIController<MedicalEconomicExamination.Domain.Entities.Patient>
    {
        public PatientExpertiseAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "Patient") { }
    }
}
