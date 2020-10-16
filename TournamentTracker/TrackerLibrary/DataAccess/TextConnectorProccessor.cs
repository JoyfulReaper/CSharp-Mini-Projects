using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TrackerLibrary.Models;
using System.Reflection.Emit;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProccessor
    {
        public static string FullFilePath(this string fileName) // PrizeModels.csv
        {
            return $"{ GetBaseFilePath() }\\{ fileName}";
        }

        public static string GetBaseFilePath()
        {
            return ConfigurationManager.AppSettings["filePath"];
        }

        public static List<string> LoadFile(this string file)
        {
            if(!Directory.Exists(GetBaseFilePath()) || !File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

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

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{ p.Id },{ p.PlaceNumber },{p.PlaceName },{ p.PrizeAmount },{p.PrizePercentage}");
            }

            if(!Directory.Exists(GetBaseFilePath()))
            {
                Directory.CreateDirectory(GetBaseFilePath());
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
