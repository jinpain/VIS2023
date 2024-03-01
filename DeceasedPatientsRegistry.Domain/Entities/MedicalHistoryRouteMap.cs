using static DeceasedPatientsRegistry.Domain.Enums;

namespace DeceasedPatientsRegistry.Domain.Entities
{
    public class MedicalHistoryRouteMap : IHasId
    {
        public Guid Id { get; set; }
        public Guid? PatientId { get; set; }
        public LocationMedicalHistory? LocationMedicalHistory { get; set; } = null;
        public string? Specialist { get; set; }
        public DateTime? DateTime { get; set; }
    }
}
