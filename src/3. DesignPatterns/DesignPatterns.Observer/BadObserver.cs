using DesignPatterns.Observer.Models;
using DesignPatterns.Observer.Pattern;

namespace DesignPatterns.Observer
{
    internal class BadObserver : ISubscriber
    {
        public void OnChanged(Book book, UpdateType updateType)
        {
            throw new NotImplementedException();
        }
    }
}
