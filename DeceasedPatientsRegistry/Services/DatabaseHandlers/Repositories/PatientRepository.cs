using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class PatientRepository : BaseRepository<Patient, PatientFilter>
    {
        public PatientRepository(IDbContextFactory<ApplicationContext> context) : base(context) { }

        public async override Task<List<Patient>> FilterAsync(PatientFilter filter)
        {
            using ApplicationContext? context = _context.CreateDbContext();
            IQueryable<Patient> patients = context.Patients.Where(x => x.IsDeleted == filter.IsDeleted);
            if (filter != null)
            {
                if (filter.DateDeathFrom != null)
                    patients = patients.Where(x => x.DateDeath.Value.Date >= filter.DateDeathFrom.Value.Date);
                if (filter.DateDeathTo != null)
                    patients = patients.Where(x => x.DateDeath.Value.Date <= filter.DateDeathTo.Value.Date);
                if (!string.IsNullOrEmpty(filter.Lastname))
                    patients = patients.Where(x => x.Lastname.Contains(filter.Lastname));
                if (!string.IsNullOrEmpty(filter.Firstname))
                    patients = patients.Where(x => x.Firstname.Contains(filter.Firstname));
                if (!string.IsNullOrEmpty(filter.Surname))
                    patients = patients.Where(x => x.Surname.Contains(filter.Surname));
                if (!string.IsNullOrEmpty(filter.MedicalHistoryNumber))
                    patients = patients.Where(x => x.MedicalHistoryNumber == filter.MedicalHistoryNumber);
            }
            return await patients.OrderByDescending(x => x.DateDeath).ToListAsync();
        }

        public async Task<Patient> GetPatientByMedicalHistoryNumber(string medicalHistoryNumber)
        {
            using ApplicationContext context = _context.CreateDbContext();
            return await context.Patients.FirstOrDefaultAsync(x => x.MedicalHistoryNumber == medicalHistoryNumber);
        }
    }
}
