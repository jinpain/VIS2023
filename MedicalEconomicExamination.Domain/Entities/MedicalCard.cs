namespace MedicalEconomicExamination.Domain.Entities
{
    public class MedicalCard
    {
        public Guid Id { get; set; }
        public string? Number { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
