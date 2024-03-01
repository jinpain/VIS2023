namespace DeceasedPatientsRegistry.Domain.Entities
{
    public class Department : IHasId
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsMain { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
