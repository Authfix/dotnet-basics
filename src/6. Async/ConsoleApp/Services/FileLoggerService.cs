namespace Asynchro.ConsoleApp;

internal class FileLoggerService
{
    private static readonly object _locker = new object();

    public void NotThreadSafeWriteToFile(string content) // N'est pas thread safe
    {
        Console.WriteLine("Opening file");
        using var streamWriter = new StreamWriter("./my-log.txt", false);

        Thread.Sleep(5000);

        Console.WriteLine("Begin Write");
        streamWriter.Write(content);
    }

    public void ThreadSafeWriteToFile(string content)
    {
        lock (_locker)
        {
            Console.WriteLine("Opening file !!");
            using var streamWriter = new StreamWriter("./my-log-2.txt", false);

            Thread.Sleep(15000); 

            Console.WriteLine("Begin Write");
            streamWriter.Write(content);
        }

    }
}
