namespace DeceasedPatientsRegistry.Data.Filters
{
    public class LogsFilter
    {
        public string? MedicalHistoryNumber { get; set; }
        public DateTime? StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; } = DateTime.Now;
    }
}
