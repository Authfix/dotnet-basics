using DesignPatterns.Observer.Pattern;

namespace DesignPatterns.Observer.Models
{
    internal class BookService : Publisher
    {
        private readonly List<Book> _books;

        public BookService(): base()
        {
            _books = new List<Book>();
        }

        /// <summary>
        /// Add a book to the collection
        /// </summary>
        /// <param name="bookToAdd">Book to add</param>
        public void Add(Book bookToAdd)
        {
            _books.Add(bookToAdd);
            Notify(bookToAdd, UpdateType.Add);
        }
    }
}
