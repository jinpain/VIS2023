namespace ForceRenderComponentLibrary
{
    public class ForceRenderComponentService : IObservable
    {
        public List<IObserver> Observers = new();
        public void RegisterObserver(IObserver o) => Observers.Add(o);
        public void RemoveObserver(IObserver o) => Observers.Remove(o);
        public void NotifyObserver(params string[] arg)
        {
            for (int i = 0; i < arg.Length; i++)
            {
                List<IObserver>? obs = Observers.Where(x => x.Name == arg[i]).ToList();
                foreach (var o in obs)
                    o.Update();
            }
        }
        public void RemoveAllObserver()
        {
            if (Observers != null)
                foreach (var item in Observers.ToList())
                    RemoveObserver(item);
        }
        public void CloseObserver(params string[] arg)
        {
            throw new NotImplementedException();
        }
        public void OpenObserver(params string[] arg)
        {
            throw new NotImplementedException();
        }
    }
}