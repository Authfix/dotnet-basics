using DesignPatterns.Observer.Models;

namespace DesignPatterns.Observer.Pattern
{
    internal abstract class Publisher
    {
        private List<ISubscriber> _subscribers;

        /// <summary>
        /// Initialize a new <see cref="Publisher"/>
        /// </summary>
        public Publisher()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriberToRemove)
        {
            _subscribers.Remove(subscriberToRemove);
        }

        protected void Notify(Book book, UpdateType updateType)
        {
            foreach (var subscriber in _subscribers)
            {
                try
                {
                    subscriber.OnChanged(book, updateType);
                }
                catch (Exception)
                {
                    Console.WriteLine("Bim le bad observer");
                }
            }
        }
    }
}
