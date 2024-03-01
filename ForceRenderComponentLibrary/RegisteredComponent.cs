namespace ForceRenderComponentLibrary
{
    public class RegisteredComponent : IObserver
    {
        public string Name { get; set; }
        public event Action CustomEvent;
        private readonly IObservable _concreteObservable;

        public RegisteredComponent(string name, IObservable concreteObservable, Action handler)
        {
            Name = name;
            _concreteObservable = concreteObservable;
            _concreteObservable.RegisterObserver(this);
            CustomEvent += handler;
        }

        public void Update() => DoSomething();
        public void DoSomething() => CustomEvent?.Invoke();
    }
}
