namespace DeceasedPatientsRegistry.Domain.Entities
{
    public class Report
    {
        public Guid Id { get; set; }
        public DateTime? DateTime { get; set; } = null;
        public string? Inspector { get; set; }
        public string? Note { get; set; }
    }
}
