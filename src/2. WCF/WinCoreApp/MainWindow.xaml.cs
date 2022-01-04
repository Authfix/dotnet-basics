using Services;
using System.Windows;

namespace MyCompany.Codex.WinCoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new CodexServiceClient();
            var creatures = client.GetCreatures();


        }
    }
}
