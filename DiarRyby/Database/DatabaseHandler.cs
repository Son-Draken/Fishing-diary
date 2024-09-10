using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;
using System.Reflection;

namespace DiarRyby
{
    /// <summary>
    /// The DatabaseHandler class manages the connection to the database and operations with fishing data.
    /// </summary>
    public class DatabaseHandler
    {
        /// <summary>
        /// Connection string to the database.
        /// </summary>
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = FishingDatabase; Integrated Security = True";

        /// <summary>
        /// Instance of the FishingManager class to manage fishing records.
        /// </summary>
        public FishingManager fishingManager = new FishingManager();



        /// <summary>
        /// DataTable to store the loaded database.
        /// </summary>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// DataTable to store data related to fish species.
        /// </summary>
        public DataTable DataTableFish { get; set; }

        /// <summary>
        /// Total number of fishing trips.
        /// </summary>
        public int FishingTripsCount { get; set; } = 0;

        /// <summary>
        /// Total number of fish caught.
        /// </summary>
        public int TotalFishCaught { get; set; } = 0;

        /// <summary>
        /// Total number of fishing areas.
        /// </summary>
        public int TotalFishingAreas { get; set; } = 0;

        /// <summary>
        /// Total number of fish kept.
        /// </summary>
        public int TotalFishKept { get; set; } = 0;

        /// <summary>
        /// List of bait types.
        /// </summary>
        public List<string> BaitList {get; set;}

        /// <summary>
        /// List of lure types.
        /// </summary>
        public List<string> LureList {get; set;}



        /// <summary>
        /// Connects to the FishingTripData database and loads data into the DataTable.
        /// </summary>
        public void ConnectData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                connection.Open();
                string query = "SELECT * FROM FishingTripData";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet result = new DataSet();     
                adapter.Fill(result, "fishingResults");
                connection.Close();
                DataTable dataTable = result.Tables["fishingResults"];
                this.DataTable = dataTable;
            }
        }

        /// <summary>
        /// Saves new fishing records to the database.
        /// </summary>
        /// <param name="fishingManager">Instance of the FishingManager class containing fishing records.</param>
        public void SaveData(FishingManager fishingManager)
        {
                // Connect to the local database and load data into the DataSet
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM  FishingTripData";
                SqlDataAdapter adapterCaught = new SqlDataAdapter();
                adapterCaught.SelectCommand = command;
                DataSet ds = new DataSet();
                adapterCaught.Fill(ds, "fishingRecord");
            // MessageBox.Show("databaze pripojena");

            // Use a for loop to iterate over the fishing records and add them to the DataSet
            /* for (int i = 0; i < fishingManager.FishingRecords.Count; i++)
             {
                 DataRow newRecord = ds.Tables["fishingRecord"].NewRow();
                 newRecord[1] = fishingManager.FishingRecords[i].AreaName;
                 newRecord[2] = fishingManager.FishingRecords[i].AreaNumber;
                 newRecord[3] = fishingManager.FishingRecords[i].Date;
                 newRecord[4] = fishingManager.FishingRecords[i].Bait;
                 newRecord[5] = fishingManager.FishingRecords[i].Lure;
                 newRecord[6] = fishingManager.FishingRecords[i].FishSpecies;
                 newRecord[7] = fishingManager.FishingRecords[i].FishCount;
                 newRecord[8] = fishingManager.FishingRecords[i].FishLength;
                 newRecord[9] = fishingManager.FishingRecords[i].FishKept;
                 ds.Tables["fishingRecord"].Rows.Add(newRecord);
              } */

            // Use a foreach loop to iterate over the fishing records and add them to the DataSet
            foreach (var lov in fishingManager.FishingRecords)
            {
                DataRow newRecord = ds.Tables["fishingRecord"].NewRow();
                newRecord[1] = lov.AreaName;
                newRecord[2] = lov.AreaNumber;
                newRecord[3] = lov.Date;
                newRecord[4] = lov.Bait;
                newRecord[5] = lov.Lure;
                newRecord[6] = lov.FishSpecies;
                newRecord[7] = lov.FishCount;
                newRecord[8] = lov.FishLength;
                newRecord[9] = lov.FishKept;
                ds.Tables["fishingRecord"].Rows.Add(newRecord);
            }

            // Automatically generate SQL commands for the DataAdapter
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapterCaught);
            adapterCaught.Update(ds.Tables["fishingRecord"]);

            connection.Close();
        }

        /// <summary>
        /// Loads data for statistical analysis.
        /// </summary> 
        public void ConnectStatisticsData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Load statistical data about fishing areas
                connection.Open();
                string query = "SELECT [AreaName] AS [Revír], " +
                               "COUNT (DISTINCT [TripDate]) AS [Počet docházek], SUM([FishCount]) AS [Uloveno ryb], SUM([FishKept]) AS [Ponecháno ryb] " +
                               "FROM[FishingTripData] GROUP BY[AreaName] ORDER BY[Počet docházek] DESC,[Uloveno ryb] DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet result = new DataSet();
                adapter.Fill(result, "fishingStatistics");
                connection.Close();
                DataTable dataTable = result.Tables["fishingStatistics"];
                this.DataTable = dataTable;

                // Load statistical data about fish species
                connection.Open();
                string query2 = "SELECT [FishSpecies] AS [Druh ryby], " +
                                "SUM([FishCount]) AS[Chyceno], SUM([FishKept]) AS [Ponechano] " +
                                "FROM[FishingTripData] GROUP BY[FishSpecies]ORDER BY[Chyceno] DESC";
                SqlDataAdapter adapter2 = new SqlDataAdapter(query2, connection);
                DataSet result2 = new DataSet();
                adapter2.Fill(result, "fishStatistics");
                connection.Close();
                DataTable dataTableFish = result.Tables["fishStatistics"];
                this.DataTableFish = dataTableFish;

                // Calculate totals using LINQ queries
                int totalTrips = dataTable.AsEnumerable().Sum(row => row.Field<int>("Počet docházek"));
                this.FishingTripsCount = totalTrips;
                int totalFishCaught = dataTable.AsEnumerable().Sum(row => row.Field<int>("Uloveno ryb"));
                this.TotalFishCaught = totalFishCaught;
                int totalFishKept = dataTable.AsEnumerable().Sum(row => row.Field<int>("Ponecháno ryb"));
                this.TotalFishKept = totalFishKept;

                // Calculate the total number of fishing areas using DataTable's Compute method. Use [AreaName] AS [Revír]
                int totalFishingAreas = Convert.ToInt32(dataTable.Compute("Count(Revír)", string.Empty));
                this.TotalFishingAreas = totalFishingAreas;
            }
        }

        /// <summary>
        /// Loads bait and lure data for selection when recording a fishing trip using a DataReader.
        /// </summary>
        public void ConnectBaitData()
        {
            BaitList = new List<string>();
            LureList = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT [Bait],[Lure] FROM FishingTripData";
                    SqlCommand command = new SqlCommand(query,connection);
                    try
                    {
                       SqlDataReader readBaitLure = command.ExecuteReader();
                       while (readBaitLure.Read())
                            {
                             BaitList.Add(readBaitLure[0].ToString());  
                             LureList.Add(readBaitLure[1].ToString());
                            }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Chyba při data readu", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message, "Chyba při připojení", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
        }

    }

    // sql command to create a table - only for test data
    /*
    CREATE TABLE [dbo].[FishingTripData] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [AreaName]    NVARCHAR (60) NULL,
    [AreaNumber]  NVARCHAR (60) NULL,
    [TripDate]    DATE          NULL,
    [Bait]        NVARCHAR (60) NULL,
    [Lure]        NVARCHAR (60) NULL,
    [FishSpecies] NVARCHAR (60) NULL,
    [FishCount]   INT           NULL,
    [FishLength]  INT           NULL,
    [FishKept]    INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
    );
    */


}
