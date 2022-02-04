using System;
using WinApp.Models;

namespace WinApp.Services
{
    internal class NewDataEventArgs : EventArgs
    {
        public NewDataEventArgs(Weather weather)
        {
            NewWeather = weather;
        }

        public Weather NewWeather { get; init; }
    }
}
