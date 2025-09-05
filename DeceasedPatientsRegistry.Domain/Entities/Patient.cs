using System.ComponentModel.DataAnnotations.Schema;
using static DeceasedPatientsRegistry.Domain.Enums;

namespace DeceasedPatientsRegistry.Domain.Entities
{
    public class Patient : IHasId
    {
        public Guid Id { get; set; }
        public Guid? ReportId { get; set; }
        public Guid? NoteKKMPId { get; set; }
        public Guid? NoteArchiveId { get; set; }
        public Guid? NoteKILIId { get; set; }
        public Guid? ConclusionKILIId { get; set; }
        public string? Lastname { get; set; }
        public string? Firstname { get; set; }
        public string? Surname { get; set; }
        public string? MedicalHistoryNumber { get; set; }
        public LocationMedicalHistory? LocationMedicalHistory { get; set; } = null;
        public AutopsyType AutopsyType { get; set; }
        public bool Expertise { get; set; } = false;
        public bool Oncology { get; set; } = false;
        public string? MainDepartmentName { get; set; }
        public string? DepartmentName { get; set; }
        public string? ArchiveName { get; set; }
        //Дата смерти пациента
        public DateTime? DateDeath { get; set; } = null;
        //Дата регистрации ИБ в архиве
        public DateTime? DateRegistration { get; set; } = null;
        //Дата постуления ИБ в отдел ККМП
        public DateTime? DateInKKMP { get; set; } = null;
        //Дата передачи секретарю КИЛИ
        public DateTime? DateInSecretaryKILI { get; set; } = null;
        //Дата поступления ИБ на КИЛИ
        public DateTime? DateInKILI { get; set; } = null;
        //Дата передачи председателю КИЛИ/зав.отдел.
        public DateTime? DateTransferKILI { get; set; } = null;
        //Дата заседания КИЛИ
        public DateTime? DateMeetingKILI { get; set; } = null;
        //Дата возврата ИБ в архив на хранение
        public DateTime? DateArchiving { get; set; } = null;
        public bool IsDeleted { get; set; } = false;
        public Report Report { get; set; } = new();
        [NotMapped]
        public Note NoteKKMP { get; set; } = new();
        [NotMapped]
        public Note NoteArchive { get; set; } = new();
        [NotMapped]
        public Note NoteKILI { get; set; } = new();
        [NotMapped]
        public ConclusionKILI ConclusionKILI { get; set; } = new();
    }
}
