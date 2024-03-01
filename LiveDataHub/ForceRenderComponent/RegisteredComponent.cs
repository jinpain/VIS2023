namespace LiveDataHub.ForceRenderComponent
{
    public class RegisteredComponent : IObserver
    {
        public string Name { get; set; }
        public event Action OnStateChanged;
        private readonly IObservable _concreteObservable;

        public RegisteredComponent(string name, IObservable concreteObservable, Action handler)
        {
            Name = name;
            _concreteObservable = concreteObservable;
            _concreteObservable.RegisterObserver(this);
            OnStateChanged += handler;
        }

        public void Update() => DoSomething();
        public void DoSomething() => OnStateChanged?.Invoke();
    }
}
