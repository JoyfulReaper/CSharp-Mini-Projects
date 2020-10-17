namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents this Persons's First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents this Person's LastName
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents this Person's Email Address
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents this Person's Cellphone number
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }
    }
}
