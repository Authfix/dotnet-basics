using System;
using System.Windows.Threading;
using WinApp.Models;

namespace WinApp.Services
{
    internal class DataService
    {
        private readonly DispatcherTimer _timer;

        public DataService()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(5);
            _timer.Tick += OnTick;
        }

        public event EventHandler<NewDataEventArgs> DataArrived;

        public void Initialize()
        {
            _timer.Start();
        }

        private void OnTick(object? sender, EventArgs e)
        {
            if (DataArrived == null) return;

            var weatherEvent = new NewDataEventArgs(new Weather());
            DataArrived(sender, weatherEvent);
        }
    }
}
