namespace Asynchro.ConsoleApp.Services
{
    internal class HttpService
    {
        private readonly HttpClient _httpClient;
        private readonly SemaphoreSlim _semaphore;

        public HttpService()
        {
            _httpClient = new HttpClient();
            _semaphore = new SemaphoreSlim(10);
        }

        public async Task GetData(int i)
        {
            try
            {
                await _semaphore.WaitAsync();

                Console.WriteLine("Getting Data " + i);

                var r = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
                Thread.Sleep(2000);

                Console.WriteLine("Data Loaded " + i);

                r.EnsureSuccessStatusCode();
            }
            finally
            {
                _semaphore.Release();
            }
        }
    }
}
