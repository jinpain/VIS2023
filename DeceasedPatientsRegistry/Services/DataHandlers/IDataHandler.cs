namespace DeceasedPatientsRegistry.Services.DataHandlers
{
    public interface IDataHandler<TEntity, TFilter> where TEntity : class
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(Guid id);
        Task<TEntity> InsertAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity entity);
        Task<List<TEntity>> FilterAsync();
    }
}
