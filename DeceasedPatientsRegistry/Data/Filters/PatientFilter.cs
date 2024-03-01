namespace DeceasedPatientsRegistry.Data.Filters
{
    public class PatientFilter
    {
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public string? MedicalHistoryNumber { get; set; }
        public DateTime? DateDeathFrom { get; set; } = new DateTime(_today.Year, _today.Month, 1);
        public DateTime? DateDeathTo { get; set; } = new DateTime(_today.Year, _today.Month,
                                                  DateTime.DaysInMonth(_today.Year, _today.Month));
        public bool IsDeleted { get; set; } = false;
        private static readonly DateTime _today = DateTime.Today;
    }
}
