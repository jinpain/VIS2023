using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalEconomicExamination.Domain.Entities
{
    public class Expertise
    {
        public Guid Id { get; set; }
        public string? Number { get; set; }
        public DateTime? Date { get; set; }
        public string? ExpertiseTypeName { get; set; }
        public string? CheckTypeName { get; set; }
        public string? BasisCheckName { get; set; }
        public string? InspectorName { get; set; }

        //связи

        [ForeignKey("Basis")]
        public Guid? BasisId { get; set; }
        public Basis? Basis { get; set; } = new();

        [ForeignKey("StructuralUnit")]
        public Guid? StructuralUnitId { get; set; }
        public StructuralUnit? StructuralUnit { get; set; } = new();


        [NotMapped]
        public CheckingResult CheckingResult { get; set; } = new();
        public List<Sanction> Sanctions { get; set; } = new();
        public List<Claim> Claims { get; set; } = new();
    }
}
