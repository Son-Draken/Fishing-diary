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
using System.Data.SqlClient;
using System.Data;

namespace DiarRyby
{
    /// <summary>
    /// Interaction logic for FishingTripPage.xaml
    /// </summary>
    public partial class FishingTripPage : Page
    {
        // Instance of FishingManager to manage fishing records.
        public FishingManager fishingManager = new FishingManager();

        // Instance of DatabaseHandler to manage database operations.
        public DatabaseHandler databaseHandler = new DatabaseHandler();

        // Instance of FishingAreaFishList to manage information about fishing areas and fish species.
        public FishingAreaFishList fishingAreaFishList = new FishingAreaFishList();


        // Code-behind for data context binding
        public FishingTripPage()
        {
            InitializeComponent();

            // Set the DataContext for binding fishing records.
            DataContext = fishingManager;

            // Bind fish species and fishing area lists to ComboBoxes.
            fishSpeciesComboBox.DataContext = fishingAreaFishList.fishSpeciesList;
            areaNameComboBox.DataContext = fishingAreaFishList.AreaList;
            areaNameComboBox.DisplayMemberPath = "AreaName";

            // Load bait and lure data from the database and bind to ComboBoxes.
            databaseHandler.ConnectBaitData();
            baitComboBox.DataContext = databaseHandler.BaitList.Distinct();
            lureComboBox.DataContext = databaseHandler.LureList.Distinct();

            //DataGrid for testing load data
            //testDataGrid.DataContext = databaseHandler.BaitList.Distinct();

            // Set the current date in the date picker if needed.
            // tripDateDataPicker.SelectedDate = DateTime.Today; 

        }

        // Constructor for data binding directly in XAML, using an existing FishingManager instance.
        //pro bindovani primo v xaml ...pro FishingCatchs
        public FishingTripPage(FishingManager fishingManager)
        {
            InitializeComponent();
            this.fishingManager = fishingManager; 
        }

        // Loads data from the page and adds a complete fishing record to the FishingCatchs collection.
        private void AddFishButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                fishingManager.AddRecord(areaNameComboBox.Text, int.Parse(areaNumberTextBox.Text), DateTime.Parse(tripDateDataPicker.Text), baitComboBox.Text,
                lureComboBox.Text, fishSpeciesComboBox.Text, int.Parse(fishCountTextBox.Text), int.Parse(fishLengthTextBox.Text), int.Parse(fishKeptCombobox.Text));

                // Clear input fields after adding the record.
                fishSpeciesComboBox.Text = "";
                fishCountTextBox.Clear();
                fishLengthTextBox.Clear();
                fishKeptCombobox.Text = "0";
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba při nahráváni do kolekce", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        
        }

        // Saves the fishing record to the PrehledLovu database and clears the form.
        private void SaveFishingRecord_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                databaseHandler.SaveData(fishingManager);

                // Clear input fields after saving the data.
                fishingManager.FishingCatchs.Clear();
                areaNumberTextBox.Clear();
                areaNameComboBox.Text = "";
                baitComboBox.Text = "";
                lureComboBox.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba při ukladani dat", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
            
        }
     

    }
}
