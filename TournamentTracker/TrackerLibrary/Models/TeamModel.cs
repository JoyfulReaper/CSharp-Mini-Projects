using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The Persons that are on this team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// The name of this Team
        /// </summary>
        public string TeamName { get; set; }
    }
}
