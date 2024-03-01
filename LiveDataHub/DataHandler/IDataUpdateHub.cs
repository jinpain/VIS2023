namespace LiveDataHub.DataHandler
{
    public interface IDataUpdateHub<TEntity>
    {
        event Action<TEntity> EntityUpdated;

        void UpdateEntity(TEntity entity);
    }
}
