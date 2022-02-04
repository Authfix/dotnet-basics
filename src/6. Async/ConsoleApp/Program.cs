using Asynchro.ConsoleApp;
using Asynchro.ConsoleApp.Services;

var loggerService = new FileLoggerService();

// Synchrone
// loggerService.WriteToFile("Hello World");

var httpService = new HttpService();

Parallel.For(0, 100, async i =>
{
    await httpService.GetData(i);
});

// var thread1 = new MyThread(loggerService);
// thread1.Start();

// var thread2 = new MyThread(loggerService);
// thread2.Start();

// var thread3 = new MyThread(loggerService);
// thread3.Start();

Console.ReadLine();