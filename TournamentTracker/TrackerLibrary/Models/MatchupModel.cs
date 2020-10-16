using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The MatchupEntries in this Matchup
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The team that won this Matchup
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// The round number
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
