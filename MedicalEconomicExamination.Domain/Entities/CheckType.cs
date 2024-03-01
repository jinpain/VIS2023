using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalEconomicExamination.Domain.Entities
{
    public class CheckType
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? BasisCheckId { get; set; }

        [NotMapped]
        public BasisCheck? BasisCheck { get; set; }
    }
}
