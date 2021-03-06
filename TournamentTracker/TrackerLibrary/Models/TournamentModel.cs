﻿using System;
using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public event EventHandler<DateTime> OnTournamentComplete;

        /// <summary>
        /// The unique identifier for the tournament
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of this Tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// The fee required to enter this Tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// The Teams that have entered this Tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// The possible prizes for coming in at a certian position in this Tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// The Rounds in this Tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

        public void CompleteTournament()
        {
            OnTournamentComplete?.Invoke(this, DateTime.Now);
        }
    }
}
