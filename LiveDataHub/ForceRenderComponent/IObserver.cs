namespace LiveDataHub.ForceRenderComponent
{
    public interface IObserver
    {
        public string Name { get; set; }
        void Update();
    }
}
