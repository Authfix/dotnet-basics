using MyCompany.MyGarage.Models;
using Serilog;
using System;

namespace MyCompany.MyGarage.ConsoleApp
{
    internal enum MenuOption
    {
        AddVehicle = 1,
        Exit = 5
    }

    internal class Application
    {
        private readonly bool _isDebug;

        /// <summary>
        /// Initialize a new <see cref="Application"/>
        /// </summary>
        /// <param name="isDebug">If the application run in debug mode or not</param>
        public Application(bool isDebug)
        {
            _isDebug = isDebug;
        }

        /// <summary>
        /// Run the main program loop
        /// </summary>
        public void Run()
        {
            var logger = GetLogger();
            var garage = new Garage(logger);

            bool exit = false;

            do
            {
                var userResponse = GetUserOption();

                switch (userResponse)
                {
                    case MenuOption.AddVehicle:
                        var volvo = new Moped();
                        garage.AddVehicle(volvo);
                        break;
                    case MenuOption.Exit:
                        exit = true;
                        break;
                }

            } while (!exit);
        }

        /// <summary>
        /// Gets the application logger
        /// </summary>
        /// <returns></returns>
        private ILogger GetLogger()
        {
            var loggerConfiguration = new LoggerConfiguration()
                .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.Console();

            if (_isDebug)
                loggerConfiguration.MinimumLevel.Debug();
            else
                loggerConfiguration.MinimumLevel.Information();

            return loggerConfiguration.CreateLogger();
        }

        private MenuOption GetUserOption()
        {
            MenuOption response;
            bool optionSuccess;

            do
            {
                Console.Clear();

                Console.WriteLine("Please choose one of the following option :");
                Console.WriteLine("1 - Add a vehicle");
                Console.WriteLine("5 - Exit\n");
                Console.WriteLine("You choice :");

                var responseString = Console.ReadLine();

                optionSuccess = Enum.TryParse(responseString, out response);

                if (!optionSuccess)
                    Console.WriteLine("Wrong option, please enter 1");

            } while (!optionSuccess);

            return response;
        }
    }
}
