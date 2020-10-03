using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The place number required to win this Prize
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of the place required to win this Prize
        /// For example "First"
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The amount of money associated with this prize
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The percentage of the total prize money to award for this prize
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
