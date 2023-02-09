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
    /// Interakční logika pro DochazkaPage.xaml
    /// </summary>
    public partial class DochazkaPage : Page
    {
       public DochazkaPage()
        {
            DataContext = spravceLovu;
            InitializeComponent();
            
        }
      
       public SpravceLovu spravceLovu = new SpravceLovu();
       public ObsluhaDatabaze obsluhaDatabaze = new ObsluhaDatabaze();

        public DochazkaPage(SpravceLovu spravceLovu)
        {
            InitializeComponent();
            this.spravceLovu = spravceLovu;
            
        }
       
        //nacte data z page a prida kompletni zapis o lovu do kolekce Lovi
        private void pridejRybuButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                spravceLovu.Pridej(revirTextBox.Text, int.Parse(cisloReviruTextBox.Text), DateTime.Parse(datumLovuDataPicker.Text), krmeniTextBox.Text,
                nastrahaTextBox.Text, druhRybyTextBox.Text, int.Parse(pocetKusuTextBox.Text), int.Parse(delkaRybTextBox.Text));
                druhRybyTextBox.Clear();
                pocetKusuTextBox.Clear();
                delkaRybTextBox.Clear();
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba jak fík", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        
        }
        //ulozi zapis lovu do databaze  PrehledLovu, vyčistí formulář
        private void ulozZapisLov_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                obsluhaDatabaze.UlozData(spravceLovu);
                spravceLovu.Lovi.Clear();
                cisloReviruTextBox.Clear();
                revirTextBox.Clear();
                krmeniTextBox.Clear();
                nastrahaTextBox.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba u ukladani dat", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
        }
    }
}
