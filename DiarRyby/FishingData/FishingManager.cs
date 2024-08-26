using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace DiarRyby
{
    /// <summary>
    /// The FishingManager class is responsible for managing fishing records(add).
    /// </summary>
    public class FishingManager
    {
        /// <summary>
        /// Observable collection to store fishing records.
        /// </summary>
        public ObservableCollection<FishingCatch>FishingCatchs { get; set; }

        /// <summary>
        /// Constructor that initializes the collection of fishing records.
        /// </summary>
        public FishingManager()
        {
            FishingCatchs = new ObservableCollection<FishingCatch>();
        }

        /// <summary>
        /// Adds a new fishing record to the Lovi collection.
        /// </summary>
        /// <param name="areaName">Name of the fishing area.</param>
        /// <param name="areaNumber">Number of the fishing area.</param>
        /// <param name="tripDate">Date of the fishing activity.</param>
        /// <param name="bait">Type of bait used.</param>
        /// <param name="lure">Type of lure used.</param>
        /// <param name="fishSpecies">Species of fish caught.</param>
        /// <param name="fishCount">Number of fish caught.</param>
        /// <param name="fishLength">Length of the fish caught.</param>
        /// <param name="fishKept">Number of fish kept.</param>
        public void AddRecord(string areaName,int areaNumber, DateTime tripDate, string bait, string lure, string fishSpecies, int fishCount, int fishLength, int fishKept)
        {
            // Validate the input data to ensure it meets the required criteria
            // Throw ArgumentException if any validation fails.
            if (areaName.Length < 3)
                throw new ArgumentException("Zápis revíru je příliš krátký");
            if (bait.Length < 3)
                throw new ArgumentException("Zápis krmení je příliš krátký");
            if (lure.Length < 3)
                throw new ArgumentException("Zápis nástraha je příliš krátký");
            if (fishSpecies.Length < 3)
                throw new ArgumentException("Zápis druhu ryb je příliš krátký");
            if (areaNumber < 3)
                throw new ArgumentException("Číslo revíru je příliš krátké");
            if (tripDate == null)
                throw new ArgumentException("Nezadal si tripDate");
            if (tripDate > DateTime.Today)
                throw new ArgumentException("Vidíš do budoucna, že víš co chytíš v následujících dnech?");
            if (fishKept > fishCount)
                throw new ArgumentException("Bereš si víc ryb než si chytil?");

            // Create a new fishing record and add it to the Lovi collection
            FishingCatch fishingCatch = new FishingCatch(areaName, areaNumber, tripDate, bait, lure, fishSpecies, fishCount, fishLength, fishKept);
            FishingCatchs.Add(fishingCatch);
        } 
    }
}
