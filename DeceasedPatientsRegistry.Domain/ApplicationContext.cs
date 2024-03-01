using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Domain
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<ConclusionKILI> ConclusionsKILI { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Archive> Archives { get; set; }
        public DbSet<MedicalHistoryRouteMap> MedicalHistoryRouteMaps { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
    }
}
