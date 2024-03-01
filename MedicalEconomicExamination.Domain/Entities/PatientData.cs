using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalEconomicExamination.Domain.Entities
{
    public class PatientData
    {
        public Guid Id { get; set; }

        //связи

        [ForeignKey("MedicalCard")]
        public Guid? MedicalCardId { get; set; }
        public MedicalCard? MedicalCard { get; set; } = new();

        [ForeignKey("InsurancePolicy")]
        public Guid? InsurancePolicyId { get; set; }
        public InsurancePolicy? InsurancePolicy { get; set; } = new();

        [ForeignKey("Expertise")]
        public Guid? ExpertiseId { get; set; }
        public Expertise? Expertise { get; set; } = new();
    }
}
