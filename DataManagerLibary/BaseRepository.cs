using DeceasedPatientsRegistry.Domain;
using Microsoft.EntityFrameworkCore;

namespace DataManagerLibary
{
    public abstract class BaseRepository<TEntity, TFilter> : IBaseRepository<TEntity, TFilter> where TEntity : class
    {
        protected readonly IDbContextFactory<ApplicationContext> _context;
        public BaseRepository(IDbContextFactory<ApplicationContext> context) => _context = context;
        public virtual async Task<List<TEntity>> GetAsync()
        {
            using var context = _context.CreateDbContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            using var context = _context.CreateDbContext();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            using var context = _context.CreateDbContext();
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            using var context = _context.CreateDbContext();
            context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteAsync(TEntity entity)
        {
            return await UpdateAsync(entity);
        }

        public abstract Task<List<TEntity>> FilterAsync(TFilter filter);
    }
}
