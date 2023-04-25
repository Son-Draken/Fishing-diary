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
        public DataTable DataTableRyby { get; set; }
        public int PocetDocházek { get; set; } = 0;
        public int CelkemUlovenoRyb { get; set; } = 0;
        public int CelkemReviru { get; set; } = 0;
        public int CelkemPonechanoRyb { get; set; } = 0;


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
            // MessageBox.Show("databaze pripojena");

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
                newZapis[9] = spravceLovu.Lovi[i].PonechanaRyba;
                ds.Tables["dataLov"].Rows.Add(newZapis);
                SqlCommandBuilder cbZapis = new SqlCommandBuilder(adapterLov);
                adapterLov.Update(ds.Tables["dataLov"]);
                }
             connection.Close();
        }

        //načte data pro statistiku 
        public void PripojDataStatistika()
        {
            using (SqlConnection pripojeni = new SqlConnection(connectionString))
            {
                pripojeni.Open();
                string dotaz = "SELECT [Revir], COUNT (DISTINCT [Datum]) AS [Počet docházek], SUM([PocetKusu]) AS [Počet ulovených ryb]" +
                               " FROM[PrehledLovu] GROUP BY[Revir] ORDER BY[Počet docházek] DESC,[Počet ulovených ryb] DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(dotaz, pripojeni);
                DataSet vysledky = new DataSet();
                adapter.Fill(vysledky, "statistikaLov");
                pripojeni.Close();
                DataTable dataTable = vysledky.Tables["statistikaLov"];
                this.DataTable = dataTable;

                pripojeni.Open();
                string dotaz2 = "SELECT [DruhRyby],SUM([PocetKusu]) AS[Počet ulovených ryb]" + 
                    " FROM[PrehledLovu] GROUP BY[DruhRyby]ORDER BY[Počet ulovených ryb] DESC";
                SqlDataAdapter adapter2 = new SqlDataAdapter(dotaz2, pripojeni);
                DataSet vysledky2 = new DataSet();
                adapter2.Fill(vysledky, "statistikaUlovky");
                pripojeni.Close();
                DataTable dataTableRyby = vysledky.Tables["statistikaUlovky"];
                this.DataTableRyby = dataTableRyby;








                //dotazy za pomoci LINQ

                int pocetDochazek = dataTable.AsEnumerable().Sum(row => row.Field<int>("Počet docházek"));
                this.PocetDocházek = pocetDochazek;

                int celkemUlovenoRyb = dataTable.AsEnumerable().Sum(row => row.Field<int>("Počet ulovených ryb"));
                this.CelkemUlovenoRyb = celkemUlovenoRyb;

                //dotaz za pomocí DataTable Compute metody

                int celkemReviru = Convert.ToInt32(dataTable.Compute("Count(Revir)", string.Empty));
                this.CelkemReviru = celkemReviru;

            }
        }




    }
}
