namespace DesignPatterns.Decorator.Locked
{
    internal sealed class Book : ILibraryItem
    {
        private readonly string _name;

        public Book(string name)
        {
            _name = name;
        }

        public void DisplayName()
        {
            Console.WriteLine(_name);
        }
    }
}
