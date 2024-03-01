namespace DataManagerLibary
{
    public abstract class DatabaseHandler<TEntity, TFilter> where TEntity : class
    {
        protected List<TEntity> _data = new();
        protected TEntity _entity;
        private readonly IBaseRepository<TEntity, TFilter> _repository;

        protected DatabaseHandler(IBaseRepository<TEntity, TFilter> repository)
        {
            _repository = repository;
        }

        protected async void GetAllAsync()
        {
            _data = await _repository.GetAsync();
        }

        protected async void GetByIdAsync(Guid id)
        {
            _entity = await _repository.GetByIdAsync(id);
        }

        protected async void InsertAsync(TEntity entity)
        {
            await _repository.InsertAsync(entity);
        }

        protected async void UpdateAsync(TEntity entity)
        {
            await _repository.UpdateAsync(entity);
        }

        protected async void DeleteAsync(TEntity entity)
        {
            await _repository.DeleteAsync(entity);
        }
    }
}
