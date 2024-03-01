namespace ForceRenderComponentLibrary
{
    public interface IObserver
    {
        public string Name { get; set; }
        void Update();
    }
}
