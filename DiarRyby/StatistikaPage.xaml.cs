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
    /// Interakční logika pro StatistikaPage.xaml
    /// </summary>
    public partial class StatistikaPage : Page
    {
        public StatistikaPage()
        {
            InitializeComponent();
            DataContext = obsluhaDatabaze;
            obsluhaDatabaze.PripojDataStatistika();
            StatistikaDataGrid.DataContext = obsluhaDatabaze.DataTable;
            PocetDochazekTextBlock.DataContext = obsluhaDatabaze.PocetDocházek;
            CelkemPonechanoRybTextBlock.DataContext = obsluhaDatabaze.CelkemPonechanoRyb;
            CelkemUlovenychRybTextBlock.DataContext = obsluhaDatabaze.CelkemUlovenoRyb;
            CelkemReviruTextBlock.DataContext = obsluhaDatabaze.CelkemReviru;
        }

        public ObsluhaDatabaze obsluhaDatabaze = new ObsluhaDatabaze();


    }
}
