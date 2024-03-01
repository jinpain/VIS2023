namespace LiveDataHub.DataHandler
{
    public class DataUpdateHub<TEntity> : IDataUpdateHub<TEntity>
    {
        public event Action<TEntity> EntityUpdated;

        public void UpdateEntity(TEntity entity)
        {
            EntityUpdated?.Invoke(entity);
        }
    }
}
