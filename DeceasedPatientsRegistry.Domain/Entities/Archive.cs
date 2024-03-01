namespace DeceasedPatientsRegistry.Domain.Entities
{
    public class Archive : IHasId
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
