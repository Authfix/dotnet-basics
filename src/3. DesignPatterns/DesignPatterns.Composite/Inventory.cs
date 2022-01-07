namespace DesignPatterns.Composite
{
    internal class Inventory
    {
        
    }

    internal interface IItemComponent
    {
        void Display();

        void Load(List<IItemComponent> c);
    }

    internal class ItemLeaf : IItemComponent
    {
        private readonly string _name;

        public ItemLeaf(string name)
        {
            _name = name;
        }

        public void Display()
        {
            Console.WriteLine(_name);
        }

        public void Load(List<IItemComponent> c)
        {
            c.Add(this);
        }
    }

    internal class ItemComposite : IItemComponent
    {
        private readonly List<IItemComponent> _components;

        public ItemComposite()
        {
            _components = new List<IItemComponent>();
        }

        internal void AddComponent(IItemComponent itemComponentToAdd)
        {
            _components.Add(itemComponentToAdd);
        }

        public void Display()
        {
            foreach (var component in _components)
            {
                component.Display();
            }
        }

        public void Load(List<IItemComponent> c)
        {
            foreach (var component in _components)
            {
                component.Load(c);
            }
        }
    }
}
