using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of this Team
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// The Persons that are on this team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
