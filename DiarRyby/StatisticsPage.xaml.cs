using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiarRyby
{
    /// <summary>
    /// Interakční logika pro StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        string TestText { get; set; } = "nic";
        public StatisticsPage()
        {
            InitializeComponent();

            // Sets the DataContext of the page to the instance of DatabaseHandler
            DataContext = databaseHandler;

            // Connects to the statistics data using the databaseHandler
            databaseHandler.ConnectStatisticsData();

            // Binds data from the databaseHandler to various UI elements
            // Binds trip overview data to a DataGrid
            previewTripDataGrid.DataContext = databaseHandler.DataTable;

            // Binds caught fish data to another DataGrid
            previewCaughtFishDataGrid.DataContext = databaseHandler.DataTableFish;

            // Binds statistical data to TextBlocks
            // Total number of trips
            totalNumberTripTextBlock.DataContext = databaseHandler.FishingTripsCount;

            // Total number of fish kept
            totalFishKeptTextBlock.DataContext = databaseHandler.TotalFishKept;

            // Total number of fish caught
            totalFishCaughtTextBlock.DataContext = databaseHandler.TotalFishCaught;

            // Total fishing areas
            totalAreaTextBlock.DataContext = databaseHandler.TotalFishingAreas;

            // Binds the TestText property to a TextBlock for testing
            testText.DataContext = TestText;
        }

        // Instance of the DatabaseHandler class used to interact with the database
        public DatabaseHandler databaseHandler = new DatabaseHandler();

       
    }
}
