// See https://aka.ms/new-console-template for more information
using DesignPatterns.Observer;
using DesignPatterns.Observer.Models;

Console.WriteLine("Hello, World!");

var observer = new LogObserver();
var observer2 = new BadObserver();

var bookService = new BookService();

bookService.Subscribe(observer);
bookService.Subscribe(observer2);
bookService.Add(new Book());

bookService.Unsubscribe(observer);
bookService.Add(new Book());

Console.WriteLine("Fin !");