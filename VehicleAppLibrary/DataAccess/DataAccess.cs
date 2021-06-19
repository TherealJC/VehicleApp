using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VehicleAppLibrary
{
    public static class DataAccess
    {
        /// <summary>
        /// Registration Number List, displays all of the Vehicles in Inventory (the textfile database).
        /// </summary>
        private static List<Vehicle> vehicleInventory = GetVehicle_All();

        public static Vehicle[] VehicleInventory => vehicleInventory.ToArray();

        private const string VehicleFile = "VehicleAppData.csv";

        /// <summary>
        /// Create VehicleModel from model, then saves the Vehicle Model to the Text File
        /// </summary>
        /// <param name="model"> A model containing the current Vehicle's Values(from createVehicleForm)</param>
        /// <returns> The Vehicle's attributes</returns>
        public static Vehicle CreateVehicle(Vehicle model)
        {
            //'vehicles' = A list containing all lines from the textfile as VehicleModels 
            //Get full file path, Load the text file, convert all text entries (lines) to List of VehicleModels
            vehicleInventory = VehicleFile.FullFilePath().LoadFile().ConvertToVehicleModel();

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
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        /// <summary>
        /// // Links the lists to display data from textfile
        /// </summary>
        /// <returns>Gets Full file path,  Loads the file, converts file contents (lines) to Vehicle Models</returns>
        public static List<Vehicle> GetVehicle_All()
        {
            return VehicleFile.FullFilePath().LoadFile().ConvertToVehicleModel();
        }
    }
}
