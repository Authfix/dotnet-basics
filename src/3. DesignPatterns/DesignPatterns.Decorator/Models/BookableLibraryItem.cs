using DesignPatterns.Decorator.Locked;

namespace DesignPatterns.Decorator.Models
{
    // Moyen de paiement : remember be.


    internal class BookableLibraryItem : ILibraryItem
    {
        private readonly ILibraryItem _item;
        private int _nbCopies = 10;

        public BookableLibraryItem(ILibraryItem item)
        {
            _item = item; 
        }

        void ILibraryItem.DisplayName()
        {
            // You can add code here
            _item.DisplayName();
            // Or here
        }

        public void Book()
        {
            _nbCopies = _nbCopies - 1;
        }
    }
}
