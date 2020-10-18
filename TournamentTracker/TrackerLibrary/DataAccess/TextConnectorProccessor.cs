using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.IO;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProccessor
    {
        /// <summary>
        /// Get the full path for the given file
        /// </summary>
        /// <param name="fileName">the file name to get the full path for</param>
        /// <returns>full path to file</returns>
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            return $"{ GetBaseFilePath() }\\{ fileName}";
        }

        public static string GetBaseFilePath()
        {
            return ConfigurationManager.AppSettings["filePath"];
        }

        /// <summary>
        /// Verify Base folder exists, and creates it if it does not
        /// </summary>
        public static void VerifyBaseFilePathExists()
        {
            if (!Directory.Exists(GetBaseFilePath()))
            {
                Directory.CreateDirectory(GetBaseFilePath());
            }
        }

        /// <summary>
        /// Loads a file and returns the contents as a list of strings
        /// </summary>
        /// <param name="file">The file to load into a list of strings</param>
        /// <returns>the contents of the file as a list of strings</returns>
        public static List<string> LoadFile(this string file)
        {
            if(!Directory.Exists(GetBaseFilePath()) || !File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        /// <summary>
        /// Converts a list of strings into a list of PrizeModel
        /// </summary>
        /// <param name="lines">List of strings to convert to list or PrizeModel</param>
        /// <returns>List of PrizeModel</returns>
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);

                output.Add(p);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            // id, team name, list of ids seperated by pipe
            // 3, My Team, 1|3|5

            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (var id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            var output = new List<PersonModel>();

            foreach (var line in lines)
            {
                string[] cols = line.Split(',');

                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                output.Add(p);
            }
            return output;
        }

        /// <summary>
        /// Saves a list of PrizeModel to a file
        /// </summary>
        /// <param name="models">The list of PrizeModel to save</param>
        /// <param name="fileName">The filename to save to</param>
        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{p.PlaceName },{ p.PrizeAmount },{p.PrizePercentage}");
            }

            VerifyBaseFilePathExists();

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (var p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.EmailAddress },{ p.CellphoneNumber }");
            }

            VerifyBaseFilePathExists();

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{ t.TeamName },{ ConvertPeopleListToString(t.TeamMembers) }");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }

            foreach (var p in people)
            {
                output += $"{ p.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }
    }
}
