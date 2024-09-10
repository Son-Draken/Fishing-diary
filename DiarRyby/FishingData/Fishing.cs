using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarRyby
{

    /// <summary>
    /// The Fishing class represents a various details of a fishing catch.
    /// </summary>
    /// 
    public class Fishing
    {

        /// <summary>
        /// The name of the fishing area.
        /// </summary>
        public string AreaName { get; set; }

        /// <summary>
        /// The number of the fishing area.
        /// </summary>
        public int AreaNumber { get; set; }

        /// <summary>
        /// The date of the fishing trip.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// The type of bait used.
        /// </summary>
        public string Bait { get; set; }

        /// <summary>
        /// The type of lure used.
        /// </summary>
        public string Lure { get; set; }

        /// <summary>
        /// The species of fish caught.
        /// </summary>
        public string FishSpecies { get; set; }

        /// <summary>
        /// The number of fish caught.
        /// </summary>
        public int FishCount { get; set; }

        /// <summary>
        /// The length of the fish caught, in centimeters.
        /// </summary>
        public int FishLength { get; set; }

        /// <summary>
        /// The number of fish that were kept.
        /// </summary>
        public int FishKept { get; set; }


        /// <summary>
        /// Constructor to initialize a fishing catch with specific details.
        /// </summary>
        /// <param name="areaName">The name of the fishing area.</param>
        /// <param name="areaNumber">The number of the fishing area.</param>
        /// <param name="date">The date of the fishing trip.</param>
        /// <param name="bait">The type of bait used.</param>
        /// <param name="lure">The type of lure used.</param>
        /// <param name="fishSpecies">The species of fish caught.</param>
        /// <param name="fishCount">The number of fish caught.</param>
        /// <param name="fishLength">The length of the fish caught, in centimeters.</param>
        /// <param name="fishKept">The number of fish kept.</param>
        public Fishing(string areaName, int areaNumber, DateTime date, string bait, string lure, string fishSpecies, int fishCount, int fishLength, int fishKept)
        {
            AreaName = areaName;
            AreaNumber = areaNumber;
            Date = date;
            Bait = bait;
            Lure = lure;
            FishSpecies = fishSpecies;
            FishCount = fishCount;
            FishLength = fishLength;    
            FishKept = fishKept;
        }

        /// <summary>
        /// Overrides the default ToString method to provide a formatted string representing the catch details.
        /// </summary>
        /// <returns>A string that includes the fish species, length, and count.</returns>
        public override string ToString()
       
        {
            return FishSpecies + ", délka: " + FishLength + "cm," + " počet: " + FishCount + " ks" ;
        }
    }
}
