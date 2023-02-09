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
    /// Interakční logika pro NahledPage.xaml
    /// </summary>
    public partial class NahledPage : Page
    {  
        public NahledPage()
        {
            InitializeComponent();
            DataContext = obsluhaDatabaze;
        }

        public ObsluhaDatabaze obsluhaDatabaze = new ObsluhaDatabaze();

        //nacteni databaze a prirazeni datatablu k datagridu
        private void nactiDataButon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                obsluhaDatabaze.PripojData();
                LovDataGrid.DataContext = obsluhaDatabaze.DataTable;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba při nahrávání dat", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }         
        }        
    }
}
