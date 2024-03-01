using DeceasedPatientsRegistry.Data.Filters;
using DeceasedPatientsRegistry.Domain;
using DeceasedPatientsRegistry.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.Repositories
{
    public class NoteRepository : BaseRepository<Note, NoteFilter>
    {
        public NoteRepository(IDbContextFactory<ApplicationContext> context) : base(context)
        {
        }

        public override Task<List<Note>> FilterAsync(NoteFilter filter)
        {
            throw new NotImplementedException();
        }
    }
}
