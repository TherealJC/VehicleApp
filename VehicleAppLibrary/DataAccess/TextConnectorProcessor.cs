using Intercom.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAppLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //VehicleModels.csv (append to the base file path)
        {                                                   //escape, escape the escape
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}"; //go to app settings, find matching key (filePath), return value
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))  //If file does not exist
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }

        public static List<VehicleModel> ConvertToVehicleModel(this List<string> lines)
        {
            List<VehicleModel> output = new List<VehicleModel>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(','); //Split/Separate entries(rows) by commas

                VehicleModel v = new VehicleModel();   //Add the vehicles attributes
                v.RegistrationNumber = columns[0];
                v.Make = columns[1];
                v.Model = columns[2];
                v.Year = columns[3];
                v.DailyHireCost = decimal.Parse(columns[4]);
                output.Add(v);  //Add vehicle values to output
            }
            return output; //return output (list of vehicle)
        }

        public static void SaveToVehicleFile(this List<VehicleModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            
            foreach (VehicleModel v in models)
            {   //Loop through each line and create a List of strings representing all Vehicles/models
                lines.Add($"{ v.RegistrationNumber }, { v.Make }, { v.Model }, { v.Year }, {v.DailyHireCost }");
            }
            //Write the new lines (overwrites old file)
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
