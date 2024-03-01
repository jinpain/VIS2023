namespace MedicalEconomicExamination.Domain.Entities
{
    public class Claim
    {
        public Guid Id { get; set; }
        public Guid? ExpertiseId { get; set; }
        public bool ClaimType { get; set; }
        public DateTime? Date { get; set; }
        public string? Note { get; set; }
    }
}
