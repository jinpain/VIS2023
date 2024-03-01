using MedicalEconomicExamination.Domain.Entities;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.MedicalEconomicExaminationAPI
{
    public class DoctorAPI : APIController<Doctor>
    {
        public DoctorAPI(IConfiguration configuration) : base(configuration, "ExpertiseAPI", "Doctor") { }
    }
}
