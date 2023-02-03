using System.Windows;

namespace DiarRyby
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = obsluhaDatabaze1;
        }

        private void zapisLovuButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DochazkaPage();
        }

        public ObsluhaDatabaze obsluhaDatabaze1 = new ObsluhaDatabaze();
        private void nahledButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new NahledPage();
            
        }
    }
}
