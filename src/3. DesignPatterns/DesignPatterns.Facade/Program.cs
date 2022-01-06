// See https://aka.ms/new-console-template for more information
using DesignPatterns.Facade;

Console.WriteLine("Create user John Doe");

var userFacade = new UserFacade();
userFacade.CreateUser("John Doe");
