namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// The unique identifier for the MatchupEntry
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique identifer for the team.
        /// </summary>
        public int TeamCompeteingId { get; set; }

        /// <summary>
        /// Represents one team in the Matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// Unqiure identifier for the parent matchup (team)
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Represents the matchup that this team came
        /// from as the winner.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
