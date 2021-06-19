using System.Collections.Generic;
using VehicleAppLibrary.DataAccess.TextHelpers;
using System.Linq;

namespace VehicleAppLibrary
{
    public static class TextConnector
    {
        //A const so that the value will never change unless changed here 
        //(pascal notation due to static const). Should the filename need to be changed,
        // it only needs to be changed once (here), instead off in multiple places.
        private const string VehicleFile = "VehicleAppData.csv";

        /// <summary>
        /// Create VehicleModel from model, then saves the Vehicle Model to the Text File
        /// </summary>
        /// <param name="model"> A model containing the current Vehicle's Values(from createVehicleForm)</param>
        /// <returns> The Vehicle's attributes</returns>
        public static VehicleModel CreateVehicle(VehicleModel model)
        {
            //'vehicles' = A list containing all lines from the textfile as VehicleModels 
            //Get full file path, Load the text file, convert all text entries (lines) to List of VehicleModels
            List<VehicleModel> vehicles = VehicleFile.FullFilePath().LoadFile().ConvertToVehicleModel();

            vehicles.Add(model); //Add the new VehicleModel record to the existing list of vehicles
            vehicles.SaveToVehicleFile(VehicleFile); //Save the list<string> to the text file.

            return model;
        }

        /// <summary>
        /// // Links the lists to display data from textfile
        /// </summary>
        /// <returns>Gets Full file path,  Loads the file, converts file contents (lines) to Vehicle Models</returns>
        public static List<VehicleModel> GetVehicle_All()
        {
            return VehicleFile.FullFilePath().LoadFile().ConvertToVehicleModel();
        }
    }
}
