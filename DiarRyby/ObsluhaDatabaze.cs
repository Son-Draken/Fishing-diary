using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;

namespace DiarRyby
{
    public class ObsluhaDatabaze
    {
        
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = KopieDatabaze; Integrated Security = True";

        public SpravceLovu spravceLovu = new SpravceLovu();
         
        //datatable k uloženi načtené databáze
        public DataTable DataTable { get; set; }

        //pripojeni databaze prehledLovu a načtení databaze do datatable 
       public void PripojData()
        {
            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            { 
                pripojeni.Open();
                string dotaz = "SELECT * FROM PrehledLovu";
                SqlDataAdapter adapter = new SqlDataAdapter(dotaz, pripojeni);
                DataSet vysledky = new DataSet();     
                adapter.Fill(vysledky,"vysledkyLov");
                pripojeni.Close();
               
                DataTable dataTable = vysledky.Tables["vysledkyLov"];
                this.DataTable = dataTable;
            }
        }
      //uložení nových záznamů o lovu do databaze 
        public void UlozData(SpravceLovu spravceLovu)
        {
            try
            {
                //pripojeni localni databaze a nacteni dat do datasetu
                //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = KopieDatabaze; Integrated Security = True";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM  PrehledLovu";
                SqlDataAdapter adapterLov = new SqlDataAdapter();
                adapterLov.SelectCommand = command;
                DataSet ds = new DataSet();
                adapterLov.Fill(ds, "dataLov");

                MessageBox.Show("databaze pripojena");


                // for cyklus dle poctu zadaných ulovku .count v zapisu lovu
                for (int i = 0; i < spravceLovu.Lovi.Count; i++)
                {
                    DataRow newZapis = ds.Tables["dataLov"].NewRow();
                    newZapis[1] = spravceLovu.Lovi[i].JmenoReviru;
                    newZapis[2] = spravceLovu.Lovi[i].CisloReviru;
                    newZapis[3] = spravceLovu.Lovi[i].Datum;
                    newZapis[4] = spravceLovu.Lovi[i].Krmeni;
                    newZapis[5] = spravceLovu.Lovi[i].Nastraha;
                    newZapis[6] = spravceLovu.Lovi[i].DruhRyby;
                    newZapis[7] = spravceLovu.Lovi[i].PocetRyby;
                    newZapis[8] = spravceLovu.Lovi[i].DelkaRyby;

                    ds.Tables["dataLov"].Rows.Add(newZapis);
                    SqlCommandBuilder cbKategorie = new SqlCommandBuilder(adapterLov);
                    adapterLov.Update(ds.Tables["dataLov"]);
                }

                connection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba u nahrani dat", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

    }
}
