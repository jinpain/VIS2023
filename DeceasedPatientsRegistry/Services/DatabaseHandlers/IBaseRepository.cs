namespace DeceasedPatientsRegistry.Services.DatabaseHandlers
{
    public interface IBaseRepository<TEntity, TFilter> where TEntity : class
    {
        Task<List<TEntity>> GetAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
        Task<List<TEntity>> FilterAsync(TFilter filter);
    }
}
