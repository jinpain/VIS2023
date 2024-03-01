using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalEconomicExamination.Domain.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string? Lastname { get; set; } //фамилия
        public string? Firstname { get; set; } //имя
        public string? Surname { get; set; } //отчество
        public DateTime? DateOfBritch { get; set; } //дата рождения
        public bool Sex { get; set; }

        //связи

        [ForeignKey("PatientData")]
        public Guid? PatientDataId { get; set; }
        public PatientData? PatientData { get; set; } = new();
    }
}
