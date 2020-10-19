using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifier for the matchup
        /// </summary>
        public int Id { get; set; }

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
