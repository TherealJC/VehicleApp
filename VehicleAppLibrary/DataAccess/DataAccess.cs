using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VehicleAppLibrary
{
    public static class DataAccess
    {
        private readonly static string VehicleFile = $@"{Environment.CurrentDirectory}\VehicleAppData.csv";
        private readonly static string ActivityFile = $@"{Environment.CurrentDirectory}\ActivityData.csv";

        /// <summary>
        /// Registration Number List, displays all of the Vehicles in Inventory (the textfile database).
        /// </summary>
        private static List<Vehicle> vehicleInventory = LoadVehicleModels(VehicleFile);
        public static Vehicle[] VehicleInventory => vehicleInventory.ToArray();

        private static List<Activity> activityInventory = LoadActivityModels(ActivityFile);
        public static Activity[] ActivityInventory => activityInventory.ToArray();

        /// <summary>
        /// Load the textfile, read all lines, create a list of all current models.
        /// If file does not exist, create a new List<string>
        /// </summary>
        /// <param name="file"></param>
        /// <returns>A list of all rows/entries in the text file</returns>
        public static List<string> LoadFile(string file)
        {
            if (!File.Exists(file))  //If file does not exist
            {
                return new List<string>(); //create a new list of string.
            }
            return File.ReadAllLines(file).ToList(); //read all lines, convert to a list
        }


        /// <summary>
        /// Create VehicleModel from model, then saves the Vehicle Model to the Text File
        /// </summary>
        /// <param name="model"> A model containing the current Vehicle's Values(from createVehicleForm)</param>
        /// <returns> The Vehicle's attributes</returns>
        public static Vehicle CreateVehicle(Vehicle model)
        {
            //'vehicles' = A list containing all lines from the textfile as VehicleModels 
            //Get full file path, Load the text file, convert all text entries (lines) to List of VehicleModels
            vehicleInventory = LoadVehicleModels(VehicleFile);

            bool vehicleExists = false;
            for(int i = 0; i < vehicleInventory.Count; i++)
            {
                Vehicle existing = vehicleInventory[i];
                if(existing.RegistrationNumber == model.RegistrationNumber)
                {
                    vehicleExists = true;
                    vehicleInventory[i] = model;
                    break;
                }
            }

            if(!vehicleExists)
            {
                vehicleInventory.Add(model);
            }

            SaveToDatabase(vehicleInventory, VehicleFile); //Save the list<string> to the text file.

            return model;
        }

        public static void DeleteVehicle(Vehicle model)
        {
            for (int i = 0; i < vehicleInventory.Count; i++)
            {
                Vehicle existing = vehicleInventory[i];
                if (existing.RegistrationNumber == model.RegistrationNumber)
                {
                    vehicleInventory.RemoveAt(i);
                    break;
                }
            }
            SaveToDatabase(vehicleInventory, VehicleFile);
        }

        public static void SaveToDatabase(List<Vehicle> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Vehicle v in models)
            {
                //Loop through each line and create a List of strings representing all Vehicles/models
                lines.Add($"{v.RegistrationNumber },{ v.Make },{ v.Model },{ v.Year },{v.DailyHireCost }");
            }
            //Write the new lines (overwrites old file)
            File.WriteAllLines(fileName, lines);
        }

        public static List<Vehicle> LoadVehicleModels(string file)
        {
            List<string> lines = LoadFile(file);

            List<Vehicle> output = new List<Vehicle>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(','); //Split/Separate entries(rows) by commas

                Vehicle v = new Vehicle();   //Add the vehicles attributes
                v.RegistrationNumber = columns[0];
                v.Make = columns[1];
                v.Model = columns[2];
                v.Year = int.Parse(columns[3]);
                v.DailyHireCost = decimal.Parse(columns[4]);
                output.Add(v);  //Add vehicle values to output
            }

            return output; //return output (list of vehicle)
        }

        public static List<Activity> LoadActivityModels(string file)
        {
            List<string> lines = LoadFile(file);

            List<Activity> output = new List<Activity>();

            foreach(string line in lines)
            {
                output.Add(Activity.LoadFromString(line));
            }

            return output;
        }



    }
}
