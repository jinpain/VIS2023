using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class LogsRepository : BaseRepository<Logs, LogsFilter>
    {
        public LogsRepository(IDbContextFactory<ApplicationContext> context) : base(context)
        {
        }

        public async override Task<List<Logs>> FilterAsync(LogsFilter filter)
        {
            using var context = _context.CreateDbContext();
            IQueryable<Logs> logs = context.Logs;
            if (filter != null)
            {
                if (filter.MedicalHistoryNumber != null)
                    logs = logs.Where(x => x.MedicalHistoryNumber == filter.MedicalHistoryNumber);
                if (filter.StartDate != null)
                    logs = logs.Where(x => x.Timestamp.Date >= filter.StartDate.Value.Date);
                if (filter.EndDate != null)
                    logs = logs.Where(x => x.Timestamp.Date <= filter.EndDate.Value.Date);
            }
            return await logs.OrderByDescending(x => x.Timestamp).ToListAsync();
        }
    }
}
