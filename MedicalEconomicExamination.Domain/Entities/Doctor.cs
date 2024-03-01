namespace MedicalEconomicExamination.Domain.Entities
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public string? DepartmentName { get; set; }
        public string? Speciality { get; set; }
        public Guid? MedicalCardId { get; set; }
    }
}
