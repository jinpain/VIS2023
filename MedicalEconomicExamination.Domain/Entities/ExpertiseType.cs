namespace MedicalEconomicExamination.Domain.Entities
{
    public class ExpertiseType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? CheckTypeName { get; set; }
        public string? BasisCheckName { get; set; }
    }
}
