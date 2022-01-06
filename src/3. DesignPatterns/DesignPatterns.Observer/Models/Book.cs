namespace DesignPatterns.Observer.Models
{
    internal class Book
    {
        public Book()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; }
    }
}
