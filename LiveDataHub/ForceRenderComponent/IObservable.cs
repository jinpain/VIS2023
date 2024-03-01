namespace LiveDataHub.ForceRenderComponent
{
    public interface IObservable
    {
        void RemoveAllObserver();
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver(params string[] arg);
        void CloseObserver(params string[] arg);
        void OpenObserver(params string[] arg);
    }
}
