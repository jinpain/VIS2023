using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class ReportRepository : BaseRepository<Report, ReportFilter>
    {
        public ReportRepository(IDbContextFactory<ApplicationContext> context) : base(context)
        {
        }

        public override Task<List<Report>> FilterAsync(ReportFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
