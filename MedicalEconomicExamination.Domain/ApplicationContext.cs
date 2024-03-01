using MedicalEconomicExamination.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MedicalEconomicExamination.Domain
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientData> PatientsData { get; set; }
        public DbSet<MedicalCard> MedicalCards { get; set; }
        public DbSet<InsurancePolicy> InsurancePolicies { get; set; }
        public DbSet<Expertise> Expertises { get; set; }
        public DbSet<Basis> Basis { get; set; }
        public DbSet<BasisType> BasisType { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Inspector> Inspectors { get; set; }
        public DbSet<ExpertiseType> ExpertiseType { get; set; }
        public DbSet<CheckType> CheckType { get; set; }
        public DbSet<BasisCheck> BasisCheck { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public DbSet<StructuralUnit> StructuralUnits { get; set; }
        public DbSet<UnitType> UnitTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Specialist> Specialists { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<CheckingResult> CheckingResults { get; set; }
        public DbSet<Sanction> Sanctions { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    }
}
