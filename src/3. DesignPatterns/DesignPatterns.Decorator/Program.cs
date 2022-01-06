// See https://aka.ms/new-console-template for more information
using DesignPatterns.Decorator.Locked;
using DesignPatterns.Decorator.Models;

Console.WriteLine("Hello, World!");

var book = new Book("David Gemmel : Waylander");
book.DisplayName();

var disc = new Disc("Naaman", 12);
disc.DisplayName();

ILibraryItem waylanderBook = new BookableLibraryItem(book);
waylanderBook.DisplayName();

var naamanDisc = new BookableLibraryItem(disc);
naamanDisc.Book();