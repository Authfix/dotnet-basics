using MyCompany.Codex.WinApp.Services;
using System.Linq;
using System.Windows;

namespace MyCompany.Codex.WinApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int MagicNumber = 42;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var client = new CodexServiceClient();
            var creatures = client.GetCreatures();

            CreatureList.ItemsSource = creatures.ToList();
        }
    }
}
