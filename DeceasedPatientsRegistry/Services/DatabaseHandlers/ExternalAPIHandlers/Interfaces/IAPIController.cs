namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.Interfaces
{
    public interface IAPIController<T> where T : class
    {
        Task<List<T>?> Get();
        Task<T?> GetById(Guid id);
        Task<T?> Add(T obj);
        Task<T?> Update(T obj);
        Task<T?> Delete(Guid id);
        Task<List<T>?> GetByListId(Guid Id);
    }
}
