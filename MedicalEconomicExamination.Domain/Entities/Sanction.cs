namespace MedicalEconomicExamination.Domain.Entities
{
    public class Sanction
    {
        public Guid Id { get; set; }
        public Guid? ExpertiseId { get; set; }
        public string? Code { get; set; }
        public bool SanctionType { get; set; }
        public string? Underpayment { get; set; }
        public string? Fine { get; set; }
    }
}
