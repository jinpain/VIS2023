using DeceasedPatientsRegistry.Services.DatabaseHandlers;
using SignalRHubLibrary;
using static SignalRHubLibrary.ActionManager;

namespace DeceasedPatientsRegistry.Services.DataHandlers
{
    public abstract class DataHandler<TEntity, TFilter> where TEntity : class
    {
        public TFilter Filter;
        protected readonly string _methodName;
        protected NotificationService _notificationService;
        protected List<TEntity> _data = new();

        private readonly IBaseRepository<TEntity, TFilter> _repository;

        public DataHandler(IBaseRepository<TEntity, TFilter> repository, NotificationService notificationService, TFilter filter, string methodName)
        {
            _repository = repository;
            _notificationService = notificationService;
            Filter = filter;
            _methodName = methodName;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            if (_data.Count == 0)
            {
                var tmp = await _repository.GetAsync();
                _data = tmp ?? new List<TEntity>();
            }
            return _data;
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async void InsertAsync(TEntity entity)
        {
            var tmp = await _repository.InsertAsync(entity);
            if (tmp != null)
                NotificationHub(tmp, ActionType.Добавил);
        }

        public async void UpdateAsync(TEntity entity)
        {
            var tmp = await _repository.UpdateAsync(entity);
            if (tmp != null)
                NotificationHub(tmp, ActionType.Обновил);
        }

        public async void DeleteAsync(TEntity entity)
        {
            var tmp = await _repository.DeleteAsync(entity);
            if (tmp != null)
                NotificationHub(tmp, ActionType.Удалил);
        }

        public async Task<List<TEntity>> FilterAsync()
        {
            _data = await _repository.FilterAsync(Filter);
            return _data;
        }

        public void SetFilter(TFilter filter)
        {
            Filter = filter;
        }

        private async void NotificationHub(TEntity obj, ActionType actionType) =>
            await _notificationService.SendNotification(_methodName, obj, actionType);
    }
}
