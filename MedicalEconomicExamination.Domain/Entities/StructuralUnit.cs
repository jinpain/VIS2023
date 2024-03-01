namespace MedicalEconomicExamination.Domain.Entities
{
    public class StructuralUnit
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? DepartmentName { get; set; }
        public string? SpecialistName { get; set; }
        public string? Speciality { get; set; }
    }
}
