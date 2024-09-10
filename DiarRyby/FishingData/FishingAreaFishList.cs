using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarRyby
{
    /// <summary>
    /// The FishingAreaFishList class represents a information about specific fishing area and fish species.
    /// It contains name of typically Czech fish and area's.
    /// </summary>
    public class FishingAreaFishList
    {
        /// <summary>
        /// List of fishing areas available for selection.
        /// </summary>
        public List<FishingArea> AreaList { get; set; }

        /// <summary>
        /// Read-only list of fish species available for selection when logging a fishing trip.
        /// </summary>
        public readonly List<string> fishSpeciesList = new List<string>() { "Kapr", "Lín", "Amur", "Plotice", "Parma", "Perlín", "Ostroretka", "Karas stříbrný", "Karas obecný",
            "Tloušť", "Jesen", "Proudník", "Cejn", "Cejnek", "Hrouzek", "Ježdík", "Ouklej", "Úhoř", "Sumec", "Sumeček americký","Štika", "Candát","Okoun" };


        /// <summary>
        /// Constructor that initializes the list with the most common fishing areas (personal preferences).
        /// </summary>
        public FishingAreaFishList()
        {
            AreaList = new List<FishingArea>()
            {
             new FishingArea("Berounka 1", 401001),
             new FishingArea("Berounka 2", 401002),
             new FishingArea("Vltava 5", 401017),
             new FishingArea("Vltava 6", 401018),
             new FishingArea("Vltava 7", 401019)
            };
        }
    }
}
