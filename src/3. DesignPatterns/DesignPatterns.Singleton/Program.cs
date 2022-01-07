using DesignPatterns.Singleton;

Console.WriteLine("Hello, World!");

var cache1 = Caching.Instance;

cache1.Add("MyKey", "my value");

Console.WriteLine("Fin");