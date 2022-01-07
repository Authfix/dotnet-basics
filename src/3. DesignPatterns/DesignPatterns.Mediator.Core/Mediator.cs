// See https://aka.ms/new-console-template for more information
using DesignPatterns.Mediator.Core;

public sealed class Mediator
{
    private readonly BookCommandHandler _bookCommandHandler;
    private readonly AddBookCommandHandler _addBookCommandHandler;

    public Mediator()
    {
        _bookCommandHandler = new BookCommandHandler();
        _addBookCommandHandler = new AddBookCommandHandler();
    }

    public bool Send(string command)
    {
        if(command == "book")
        {
            return _bookCommandHandler.Book();
        }

        if(command == "add")
        {
            return _addBookCommandHandler.AddBook();
        }

        return false;
    }
}