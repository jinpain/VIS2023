using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class ConclusionRepository : BaseRepository<ConclusionKILI, ConclusionKILIFilter>
    {
        public ConclusionRepository(IDbContextFactory<ApplicationContext> context) : base(context)
        {
        }

        public override Task<List<ConclusionKILI>> FilterAsync(ConclusionKILIFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
