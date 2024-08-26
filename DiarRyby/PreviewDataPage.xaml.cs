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
    /// Interakční logika pro PreviewDataPage.xaml
    /// </summary>
    public partial class PreviewDataPage : Page
    {  
        public PreviewDataPage()
        {
            InitializeComponent();
            DataContext = databaseHandler;  
        }

        public DatabaseHandler databaseHandler = new DatabaseHandler();

        //nacteni databaze a prirazeni datatablu k datagridu
        private void LoadDataButon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                databaseHandler.ConnectData();
                TripDataGrid.DataContext = databaseHandler.DataTable;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba při nahrávání dat", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }         
        }
    }
}
