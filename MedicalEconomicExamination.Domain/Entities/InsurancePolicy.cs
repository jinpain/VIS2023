namespace MedicalEconomicExamination.Domain.Entities
{
    public class InsurancePolicy
    {
        public Guid Id { get; set; }
        public string? Number { get; set; }
        public string? InsuranceCompany { get; set; }
    }
}
