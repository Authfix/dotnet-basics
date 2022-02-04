using System;

namespace WinApp.Models
{
    internal class Weather
    {
        public Weather()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; }
    }
}
