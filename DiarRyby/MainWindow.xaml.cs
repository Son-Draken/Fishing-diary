
using System.Windows;


namespace FishingDiary

{
    /// <summary>
    ///  Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Changes the content of the "Main" frame to the TripFishingPage
        private void FishingRecordButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new TripFishingPage();
        }

        // Changes the content of the "Main" frame to the DatabasePreviewPage
        private void PreviewButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new DatabasePreviewPage();
            
        }

        // Changes the content of the "Main" frame to the StatisticsPage
        private void StatisticsButton_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new StatisticsPage();
        }

    
    }
}
