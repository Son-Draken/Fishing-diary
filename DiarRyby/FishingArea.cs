using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiarRyby
{
    /// <summary>
    /// The FishingArea class represents a specific fishing area or location.
    /// It contains properties for the area's name and its unique identification number.
    /// </summary>
    public class FishingArea
    {
        /// <summary>
        /// Gets or sets the name of the fishing area.
        /// </summary>
        public string AreaName { get; set; }

        /// <summary>
        /// Gets or sets the unique number assigned to the fishing area.
        /// </summary>
        public int AreaNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the FishingArea class with a specified name and number.
        /// </summary>
        /// <param name="areaName">The name of the fishing area.</param>
        /// <param name="areaNumber">The unique number of the fishing area.</param>
        public FishingArea(string areaName, int areaNumber)
        {
            AreaName = areaName;
            AreaNumber = areaNumber;
        }

    }
}
