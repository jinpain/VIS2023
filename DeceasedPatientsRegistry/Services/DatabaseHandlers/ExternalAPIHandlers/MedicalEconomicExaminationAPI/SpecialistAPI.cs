using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class SpecialistAPI : APIController<Specialist>
    {
        public SpecialistAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "Specialist") { }
    }
}
