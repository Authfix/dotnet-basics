using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using WinApp.Exceptions;
using WinApp.Services;

namespace WinApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window // Thread UI
    {
        private readonly DataService _service;

        public MainWindow()
        {
            InitializeComponent();

            _service = new DataService();
            _service.Initialize();
        }

        private void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            _service.DataArrived += OnDataArrived;
            _service.DataArrived += OnDataArrivedBis;
        }

        private void OnWindowUnloaded(object sender, RoutedEventArgs e)
        {
            _service.DataArrived -= OnDataArrived;
            _service.DataArrived -= OnDataArrivedBis;
        }

        private void OnDataArrived(object? sender, NewDataEventArgs e)
        {
            MyButton.Content = e.NewWeather.Id;
        }

        private void OnDataArrivedBis(object? sender, NewDataEventArgs e)
        {
            MyLabel.Content = e.NewWeather.Id;
        }

        private async void OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                await Task.Run(() =>
                 {
                     Thread.Sleep(3000);
                     throw new AppException();
                 });

                Parallel.For(0, 500000, i =>
                {
                    if (i == 10523)
                        throw new TimeoutException("i = 10523");
                    Console.WriteLine(i + "\n");
                });
            }
            catch (AppException aa)
            {

            }
            catch(TimeoutException t)
            {

            }
            catch(Exception ex)
            {

            }


            try
            {
                MyProgress.Visibility = Visibility.Visible;

                await Task.Delay(4000);
            }
            finally
            {
                MyProgress.Visibility = Visibility.Collapsed;
            }

            MyButton.Content = "Task Finished";
        }
    }
}
