// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
// Author : Jamie Crowther
// Published Date : 22/06/2021

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VehicleAppLibrary
{
    public static class DataAccess
    {
        // File location strings
        private readonly static string _vehicleFile = $@"{Environment.CurrentDirectory}\VehicleAppData.csv";
        private readonly static string _activityFile = $@"{Environment.CurrentDirectory}\ActivityData.csv";

        // Registration Number List, displays all of the Vehicles in Inventory (the textfile database).
        private static List<Vehicle> _vehicleInventory = LoadVehicleModels(_vehicleFile);
        public static Vehicle[] VehicleInventory => _vehicleInventory.ToArray();

        // Loads activity models, used for activity List. 
        private static readonly List<Activity> _activityInventory = LoadActivityModels();
        public static Activity[] ActivityInventory => _activityInventory.ToArray();

        

        /// <summary>
        /// Load file (if exists, otherwise create new file), read all lines, convert to list.
        /// </summary>
        public static List<string> LoadFile(string file)
        {
            if (!File.Exists(file))  //If file does not exist
            {
                return new List<string>(); //create a new list of string.
            }
            return File.ReadAllLines(file).ToList(); //read all lines, convert to a list
        }



        /// <summary>
        /// Load Vehicles from a The Vehicle textfile
        /// </summary>
        public static List<Vehicle> LoadVehicleModels(string file)
        {
            List<string> lines = LoadFile(file);

            List<Vehicle> output = new List<Vehicle>();

            foreach (string line in lines)
            {
                string[] columns = line.Split(','); // Split/Separate entries(rows) by commas

                Vehicle v = new Vehicle();   // Add the vehicles attributes
                v.RegistrationNumber = columns[0];
                v.Make = columns[1];
                v.Model = columns[2];
                v.Year = int.Parse(columns[3]);
                v.DailyHireCost = decimal.Parse(columns[4]);
                output.Add(v);  // Add vehicle values to output
            }

            return output; // return output (list of vehicle)
        }



        /// <summary>
        /// Called create Vehicle, but really I changed the functionality to "PutVehicle" in a more traditional sense.
        /// </summary>
        public static Vehicle CreateVehicle(Vehicle model)
        {
            _vehicleInventory = LoadVehicleModels(_vehicleFile); //Load all vehicles from file

            bool vehicleExists = false;

            for (int i = 0; i < _vehicleInventory.Count; i++)
            {
                Vehicle existing = _vehicleInventory[i];
                if (existing.RegistrationNumber == model.RegistrationNumber)
                {
                    vehicleExists = true;
                    _vehicleInventory[i] = model;
                    break;
                }
            }

            if (!vehicleExists) //If no matching registration is found
            {
                _vehicleInventory.Add(model); //Add the vehicle to the list/inventory
            }

            SaveVehiclesToFile(_vehicleInventory, _vehicleFile); //Save the updated Vehicle text file.

            return model;
        }



        /// <summary>
        /// Check if registration number exists in the database already when creating a Vehicle
        /// </summary>
        public static bool CheckVehicleExists(string registration)
        {
            bool vehicleExists = false;
            for (int i = 0; i < _vehicleInventory.Count; i++)
            {
                Vehicle existing = _vehicleInventory[i];
                if (existing.RegistrationNumber == registration)
                {
                    vehicleExists = true;
                    break;
                }
            }
            return vehicleExists;
        }


        /// <summary>
        /// Save a List of Vehicles to a file
        /// </summary>
        /// <param name="models">A List of Vehicles</param>
        /// <param name="fileName">Name of the textfile being saved to</param>
        private static void SaveVehiclesToFile(List<Vehicle> models, string fileName)
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


        /// <summary>
        /// Remove selected Vehicle from file, loops through until it finds a matching Registration number (textfile entry matching with 
        /// current/selected Vehicles Registraion Number). Remove the entry. Save to files again to update data/ keep persistent data
        /// Also removes any activities related to that Vehicle
        /// </summary>
        public static void DeleteVehicle(Vehicle model)
        {
            for (int i = 0; i < _vehicleInventory.Count; i++)
            {
                Vehicle existing = _vehicleInventory[i];
                if (existing.RegistrationNumber == model.RegistrationNumber)
                {
                    _vehicleInventory.RemoveAt(i);
                    break;
                }
            }
            SaveVehiclesToFile(_vehicleInventory, _vehicleFile);
            SaveActivitiesToFile(LoadActivityModels().Where(a => a.RegistrationNumber != model.RegistrationNumber).ToList(), _activityFile);
        }



        /// <summary>
        /// Used for mapping activities to a Vehicle. Each activity automatically gets a registration number 
        /// (from the Vehicle that the activity was added to). This method returns all activities where
        /// the registration number matches (Used for the activity list on ActivityLog)
        /// </summary>
        public static List<Activity> GetVehicleActivities(string registration)
        {
            List<Activity> output = new List<Activity>();

            foreach (Activity a in LoadActivityModels())
            {
                if (a.RegistrationNumber == registration)
                    output.Add(a);
            }

            return output;
        }



        /// <summary>
        /// Load Activities from Activity file
        /// </summary>
        public static List<Activity> LoadActivityModels()
        {
            List<string> lines = LoadFile(_activityFile);

            List<Activity> output = new List<Activity>();

            foreach (string line in lines)
            {
                output.Add(Activity.LoadFromString(line));
            }

            return output;
        }


        /// <summary>
        /// Create an activity
        /// </summary>
        /// <param name="model"></param>
        public static void CreateActivity(Activity model)
        {
            List<Activity> database = LoadActivityModels(); //database = List of all activities from ActivityFile

            bool activityExists = false;

            for (int i = 0; i < database.Count; i++) //Loop to check if Activity exists (through ID)
            {
                Activity existing = database[i];
                if (existing.ActivityID == model.ActivityID)
                {
                    activityExists = true; //If matching ID is found, break
                    database[i] = model;
                    break;
                }
            }

            if (!activityExists) //If activityID does not find any match
            database.Add(model);
            SaveActivitiesToFile(database, _activityFile); //Add a new activity to database/ActivityFile
        }


        /// <summary>
        /// Delete a selected activity
        /// </summary>
        /// <param name="ActivityID"></param>
        public static void DeleteActivity(int ActivityID)
        {
            List<Activity> database = LoadActivityModels();
            for(int i = 0; i < database.Count; ++i)
            {
                Activity a = database[i];
                if (a.ActivityID == ActivityID)
                {
                    database.RemoveAt(i); //Remove Activity where match is found
                    break;
                }
            }
            SaveActivitiesToFile(database, _activityFile); //Save to file to update the data (ensuring entry is deleted correctly)
        }



        /// <summary>
        /// Save an activity to file
        /// </summary>
        private static void SaveActivitiesToFile(List<Activity> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Activity a in models)
            {
                lines.Add(a.SaveString()); //SaveString() specified in each Activity sub-class (A string containing all of the activities values)
            }

            //Write the new lines (overwrites old file)
            File.WriteAllLines(fileName, lines);
        }


        /// <summary>
        /// Loads all activities, gets the highest ID, and add +1 (Used when adding a new entry)
        /// </summary>
        /// <returns>Automatically generated ActivityID</returns>
        public static int GetNextActivityID()
        {
            int highest = 0;
            foreach (Activity a in LoadActivityModels())
            {
                if (a.ActivityID > highest)
                    highest = a.ActivityID;
            }
            return highest + 1;
        }
    }
}
