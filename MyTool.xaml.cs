using System.Windows;

namespace MyTool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Wochenplan wochenplan = new Wochenplan();
            wochenplan.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wochenplan.Show();
            

        }
    }
}
