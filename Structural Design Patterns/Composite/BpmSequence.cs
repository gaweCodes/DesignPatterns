using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Composite
{
    public class BpmSequence : BpmComponent
    {
        private readonly List<BpmComponent> _components;
        public BpmSequence(int id) : base(id)
        {
            _components = new List<BpmComponent>();
        }
        public override void Draw()
        {
            Debug.Print("Draw something");
        }
        public void Add(BpmComponent component)
        {
            _components.Add(component);
        }
        public void Remove(BpmComponent component)
        {
            _components.Remove(component);
        }
        public BpmComponent GetChild(int id)
        {
            return _components.FirstOrDefault(c => c.Id == id);
        }
        public override void Start()
        {
            _components.ForEach(c => c.Start());
        }
    }
}
