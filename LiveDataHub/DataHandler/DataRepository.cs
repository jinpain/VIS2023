using Microsoft.EntityFrameworkCore;

namespace LiveDataHub.DataHandler
{
    public class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : class
    {
        private readonly IDbContextFactory<DbContext> _context;    
        private readonly DbContext _dbContext;

        public DataRepository(IDbContextFactory<DbContext> context) => _context = context;

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _dbContext.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
