using System.Windows;

namespace DiarRyby
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

        // Event handler for when the "Fishing Record" button is clicked
        private void FishingTripButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new FishingTripPage();
        }

        // Event handler for when the "Preview" button is clicked
        private void PreviewDataButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PreviewDataPage();
            
        }

        // Event handler for when the "Statistics" button is clicked
        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new StatisticsPage();
        }

    
    }
}
