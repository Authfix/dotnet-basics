// See https://aka.ms/new-console-template for more information
using DesignPatterns.Observer.Models;
using DesignPatterns.Observer.Pattern;

internal class LogObserver : ISubscriber
{
    public void OnChanged(Book book, UpdateType updateType)
    {
        Console.WriteLine(book.Id);
    }
}