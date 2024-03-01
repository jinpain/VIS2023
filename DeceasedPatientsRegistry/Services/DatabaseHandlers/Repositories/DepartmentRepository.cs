using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class DepartmentRepository : BaseRepository<Department, DepartmentFilter>
    {
        public DepartmentRepository(IDbContextFactory<ApplicationContext> context) : base(context)
        {
        }

        public override Task<List<Department>> FilterAsync(DepartmentFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
