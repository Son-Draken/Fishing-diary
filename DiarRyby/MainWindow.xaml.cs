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
           
        }

        private void zapisLovuButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DochazkaPage();
        }
    }
}
