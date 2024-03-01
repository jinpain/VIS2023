namespace DataManagerLibary
{
    public class DataManagerService<TEntity, TFilter> : DatabaseHandler<TEntity, TFilter> where TEntity : class
    {
        public DataManagerService(IBaseRepository<TEntity, TFilter> repository) : base(repository)
        {

        }
    }
}
