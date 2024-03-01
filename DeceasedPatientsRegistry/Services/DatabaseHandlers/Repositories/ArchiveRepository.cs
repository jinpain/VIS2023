using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class ArchiveRepository : BaseRepository<Archive, ArchiveFilter>
    {
        public ArchiveRepository(IDbContextFactory<ApplicationContext> context) : base(context)
        {
        }

        public override Task<List<Archive>> FilterAsync(ArchiveFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
