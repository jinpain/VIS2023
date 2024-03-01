using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class MedicalHistoryRouteMapRepository : BaseRepository<MedicalHistoryRouteMap, MedicalHistoryRouteMapFilter>
    {
        public MedicalHistoryRouteMapRepository(IDbContextFactory<ApplicationContext> context) : base(context)
        {
        }

        public async override Task<List<MedicalHistoryRouteMap>> FilterAsync(MedicalHistoryRouteMapFilter filter)
        {
            using var context = _context.CreateDbContext();
            IQueryable<MedicalHistoryRouteMap> tmp = context.MedicalHistoryRouteMaps;
            if (filter != null)
            {
                if (filter.PatientId != null)
                    tmp = tmp.Where(x => x.PatientId == filter.PatientId);
            }
            return await tmp.OrderByDescending(x => x.DateTime).ToListAsync();
        }
    }
}
