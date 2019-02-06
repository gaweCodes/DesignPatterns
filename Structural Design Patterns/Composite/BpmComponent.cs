namespace Composite
{
    public abstract class BpmComponent
    {
        public int Id { get; }
        public abstract void Draw();
        public abstract void Start();
        protected BpmComponent(int id)
        {
            Id = id;
        }
    }
}
