using DesignPatterns.Observer.Models;

namespace DesignPatterns.Observer.Pattern
{
    internal interface ISubscriber
    {
        /// <summary>
        /// Occurs when a book changed inside the library.
        /// </summary>
        /// <param name="book">The book.</param>
        /// <param name="updateType">The type of update.</param>
        void OnChanged(Book book, UpdateType updateType);
    }
}
