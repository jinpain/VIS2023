using static DeceasedPatientsRegistry.Domain.Enums;

namespace DeceasedPatientsRegistry.Domain.Entities
{
    public class Logs : IHasId
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string MedicalHistoryNumber { get; set; }
        public DateTime Timestamp { get; set; }
        public ActionType ActionType { get; set; }
    }
}
