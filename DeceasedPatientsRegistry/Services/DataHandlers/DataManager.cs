using DeceasedPatientsRegistry.Domain.Entities;
using DeceasedPatientsRegistry.Services.DatabaseHandlers;
using ForceRenderComponentLibrary;
using SignalRHubLibrary;
using static SignalRHubLibrary.ActionManager;

namespace DeceasedPatientsRegistry.Services.DataHandlers
{
    public class DataManager<TEntity, TFilter> : DataHandler<TEntity, TFilter> where TEntity : class, IHasId
    {
        private Dictionary<ActionType, Action<TEntity, ActionType>>? _actionMap;
        private readonly ForceRenderComponentService _forceRenderComponentService;
        private readonly string _componentName;

        public DataManager(IBaseRepository<TEntity, TFilter> repository, NotificationService notificationService, TFilter filter, string methodName, string componentName, ForceRenderComponentService forceRenderComponentService) : base(repository, notificationService, filter, methodName)
        {
            notificationService.RegisterHandler<TEntity, ActionType>(methodName, OnNotifyReceived);
            _forceRenderComponentService = forceRenderComponentService;
            _componentName = componentName;
            InitializeDictionary();
        }

        public List<TEntity> GetCachedData()
        {
            return _data;
        }

        private void OnNotifyReceived(TEntity entity, ActionType actionType)
        {
            if (_actionMap == null)
                InitializeDictionary();
            _actionMap?[actionType].Invoke(entity, actionType);
            _forceRenderComponentService.NotifyObserver(_componentName);
        }

        private void InitializeDictionary()
        {
            _actionMap = new Dictionary<ActionType, Action<TEntity, ActionType>>
            {
                { ActionType.Добавил, (x, y) => InsertCachedData(x) },
                { ActionType.Обновил, (x, y) => UpdateCachedData(x) },
                { ActionType.Удалил, (x, y) => DeleteCachedData(x) }
            };
        }

        private void InsertCachedData(TEntity entity)
        {
            _data.Add(entity);
        }

        private void UpdateCachedData(TEntity entity)
        {
            int index = _data.FindIndex(item => item.Id == entity.Id);
            if (index != -1)
                _data[index] = entity;
            else
                _data.Add(entity);
        }

        private void DeleteCachedData(TEntity entity)
        {
            int index = _data.FindIndex(item => item.Id == entity.Id);
            if (index != -1)
                _data.RemoveAt(index);
        }
    }
}
