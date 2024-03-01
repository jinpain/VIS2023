namespace MedicalEconomicExamination.Domain.Entities
{
    public class CheckingResult
    {
        public Guid Id { get; set; }
        public Guid? ExpertiseId { get; set; }
        public string? Note { get; set; }
    }
}
