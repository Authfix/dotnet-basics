using Serilog;
using System.Linq;

namespace MyCompany.MyGarage.ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var argsList = args.ToList();
            var isDebug = argsList.Contains("--debug");            

            var application = new Application(isDebug);
            application.Run();
        }
    }
}
