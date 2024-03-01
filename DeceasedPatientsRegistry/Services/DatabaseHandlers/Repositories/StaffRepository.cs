using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class StaffRepository : BaseRepository<Staff, StaffFilter>
    {
        public StaffRepository(IDbContextFactory<ApplicationContext> context) : base(context)
        {
        }

        public override Task<List<Staff>> FilterAsync(StaffFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
