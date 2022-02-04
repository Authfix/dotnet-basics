namespace Asynchro.ConsoleApp;

internal class MyThread
{
    private readonly FileLoggerService _loggerService;
    private readonly Thread _thread;

    public MyThread(FileLoggerService loggerService)
    {
        _loggerService = loggerService;
        _thread = new Thread(() => 
        {
            //_loggerService.NotThreadSafeWriteToFile(Thread.CurrentThread.ManagedThreadId.ToString());
            _loggerService.ThreadSafeWriteToFile(Thread.CurrentThread.ManagedThreadId.ToString());
        });
    }

    public void Start()
    {
        _thread.Start();
    }
}
