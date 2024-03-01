namespace MedicalEconomicExamination.Domain.Entities
{
    public class BasisType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? NumberBasis { get; set; }
        public DateTime? Date { get; set; }
    }
}
