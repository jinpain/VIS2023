namespace MedicalEconomicExamination.Domain.Entities
{
    public class Basis
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Number { get; set; }
        public DateTime? Date { get; set; }
        public Guid? NoteId { get; set; }
        public Note? Note { get; set; } = new();
    }
}
