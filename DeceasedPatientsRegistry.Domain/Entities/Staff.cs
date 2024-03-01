namespace DeceasedPatientsRegistry.Domain.Entities
{
    public class Staff : IHasId
    {
        public Guid Id { get; set; }
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
